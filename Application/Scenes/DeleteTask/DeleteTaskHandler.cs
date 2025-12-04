using Application.Interfaces;

namespace Application.Scenes.DeleteTask;

public class DeleteTaskHandler(IUnitOfWork unitOfWork) : IHandler<DeleteTaskRequest, bool>
{
    public async Task<bool> HandleAsync(DeleteTaskRequest request, CancellationToken cancellationToken)
    {
        var taskBoard = await unitOfWork.TaskBoardRepository.GetTaskBoardAsync(request.BoardId);
        taskBoard.Tasks.Remove(taskBoard.Tasks.Find(p => p.Id == request.TaskId)!);

        await unitOfWork.SaveChangeAsync(cancellationToken);
        
        return true;
    }
}