using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.Extensions.Logging;

namespace Application.Scenes.ListAllTask;

public class ListAllTaskHandler(IUnitOfWork unitOfWork) : IHandler<ListAllTaskRequest, ListAllTaskResponse>
{
    public async Task<ListAllTaskResponse> HandleAsync(ListAllTaskRequest request, CancellationToken cancellationToken)
    {
        var taskBoard = await unitOfWork.TaskBoardRepository.GetTaskBoardAsync(request.Id);
        
        var pagedTasks = taskBoard.Tasks.Skip(request.Page * request.PageSize).Take(request.PageSize);
        
        var response = new ListAllTaskResponse(pagedTasks);

        return response;
    }
}