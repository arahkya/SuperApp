using Application.Interfaces;
using Domain.Shared;
using Domain.TaskManagement;

namespace Application.Scenes.DeleteTask;

public class DeleteTaskHandler(IUnitOfWork unitOfWork) : IHandler<DeleteTaskRequest, bool>
{
    public async Task<bool> HandleAsync(DeleteTaskRequest request, CancellationToken cancellationToken)
    {
        var taskBoard = await unitOfWork.TaskBoardRepository.GetTaskBoardAsync(request.BoardId);
        var task = taskBoard.Tasks.Find(p => p.Id == request.TaskId)!;
        
        taskBoard.Tasks.Remove(task);

        await unitOfWork.SaveChangeAsync(cancellationToken);
        
        var taskCreatedEvent = new TaskDomainEvent(task)
        {
            Type = DomainEventBase<TaskEntity>.EventType.Deleted
        };
        
        await unitOfWork.TaskEvents.Writer.WriteAsync(taskCreatedEvent, cancellationToken);
        
        return true;
    }
}