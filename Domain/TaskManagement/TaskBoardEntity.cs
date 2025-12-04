using System.ComponentModel.DataAnnotations;
using Domain.Shared;
using Microsoft.Extensions.Logging;

namespace Domain.TaskManagement;

public class TaskBoardEntity : RootAggregateEntityBase<Guid>
{
    public List<TaskEntity> Tasks { get; internal init; } = [];
    
    public TaskEntity CreateTask(string title, string? description)
    {
        var newTask = new TaskEntity
        {
            Title = title,
            Description = description ?? string.Empty,
            CreatedOn = DateTimeProvider.CurrentDateTime()
        };

        var validateResult = newTask.IsValid();
        var isValid = validateResult.Count == 0;
        
        if (isValid)
        {
            Tasks.Add(newTask);
            
            return newTask;
        }
        
        var validationException = new ValidationException(string.Join(Environment.NewLine, validateResult));
        throw validationException;
    }

    public Task UpdateAsync(TaskEntity taskEntity)
    {
        var validateResult = taskEntity.IsValid();
        var isValid = validateResult.Count == 0;

        if (isValid) return Task.CompletedTask;
        
        var validationException = new ValidationException(string.Join(Environment.NewLine, validateResult));
        throw validationException;
    }
}