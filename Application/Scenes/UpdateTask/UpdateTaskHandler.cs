using System.ComponentModel.DataAnnotations;
using Application.Interfaces;
using Domain.Shared;
using Domain.TaskManagement;
using Microsoft.Extensions.Logging;

namespace Application.Scenes.UpdateTask;

public class UpdateTaskHandler(IUnitOfWork unitOfWork, ILoggerFactory loggerFactory) : IHandler<UpdateTaskRequest, bool>
{
    public async Task<bool> HandleAsync(UpdateTaskRequest request, CancellationToken cancellationToken)
    {
        var logger = loggerFactory.CreateLogger<UpdateTaskRequest>();
        var taskBoard = await unitOfWork.TaskBoardRepository.GetTaskBoardAsync(request.BoardId);
        var taskEntity = taskBoard.Tasks.Single(t => t.Id == request.TaskId);

        try
        {
            taskEntity.Title = request.Title;
            taskEntity.Description = request.Description ?? string.Empty;
            
            await taskBoard.UpdateAsync(taskEntity);
        }
        catch (ValidationException validationException)
        {
            logger.LogError(validationException, "Invalid Task Info Detected.");
            
            throw new Exception("Fail to create Task",  validationException);
        }
        
        await unitOfWork.SaveChangeAsync(cancellationToken);

        var taskCreatedEvent = new TaskDomainEvent(taskEntity)
        {
            Type = DomainEventBase<TaskEntity>.EventType.Updated
        };
        
        await unitOfWork.TaskEvents.Writer.WriteAsync(taskCreatedEvent, cancellationToken);

        return true;
    }
}