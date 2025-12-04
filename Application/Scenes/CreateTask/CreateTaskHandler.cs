using System.ComponentModel.DataAnnotations;
using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.Extensions.Logging;

namespace Application.Scenes.CreateTask;

public class CreateTaskHandler(IUnitOfWork unitOfWork, ILoggerFactory loggerFactory) : IHandler<CreateTaskRequest, Guid>
{
    public async Task<Guid> HandleAsync(CreateTaskRequest request, CancellationToken cancellationToken)
    {
        var logger = loggerFactory.CreateLogger<CreateTaskHandler>();
        var taskBoard = await unitOfWork.TaskBoardRepository.GetTaskBoardAsync(request.BoardId);
        var taskEntity = default(TaskEntity);

        try
        {
            taskEntity = taskBoard.CreateTask(request.Title, request.Description);
        }
        catch (ValidationException validationException)
        {
            logger?.LogError(validationException, "Invalid Task Info Detected.");
            
            throw new Exception("Fail to create Task",  validationException);
        }

        if (taskBoard.Tasks.Count > 50)
        {
            logger?.LogWarning("Task over limit (51)");
        }
        
        await unitOfWork.SaveChangeAsync(cancellationToken);

        var taskCreatedEvent = new TaskCreatedEvent(taskEntity);
        await unitOfWork.TaskEvents.Writer.WriteAsync(taskCreatedEvent, cancellationToken);

        return taskEntity.Id;
    }
}