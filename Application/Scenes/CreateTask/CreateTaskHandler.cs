using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.Extensions.Logging;

namespace Application.Scenes.CreateTask;

public class CreateTaskHandler(IUnitOfWork unitOfWork, ILoggerFactory loggerFactory) : IHandler<CreateTaskRequest, Guid>
{
    public async Task<Guid> HandleAsync(CreateTaskRequest request, CancellationToken cancellationToken)
    {
        var taskBoard = new TaskBoardEntity(loggerFactory)
        {
            Tasks = [.. await unitOfWork.TaskRepository.ListAllAsync()]
        };
        var taskEntity = taskBoard.CreateTask(request.Title, request.Description);

        if (taskBoard.Tasks.Count > 50)
        {
            var logger = loggerFactory.CreateLogger<CreateTaskHandler>();
            logger.LogWarning("Task over limit (51)");
        }
        
        await unitOfWork.TaskRepository.AddAsync(taskEntity);
        await unitOfWork.SaveChangeAsync(cancellationToken);

        var taskCreatedEvent = new TaskCreatedEvent(taskEntity);
        await unitOfWork.TaskEvents.Writer.WriteAsync(taskCreatedEvent, cancellationToken);

        return taskEntity.Id;
    }
}