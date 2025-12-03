using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.Extensions.Logging;

namespace Application.Scenes.ListAllTask;

public class ListAllTaskHandler(IUnitOfWork unitOfWork, ILoggerFactory loggerFactory) : IHandler<ListAllTaskRequest, ListAllTaskResponse>
{
    public async Task<ListAllTaskResponse> HandleAsync(ListAllTaskRequest request, CancellationToken cancellationToken)
    {
        var taskBoard = new TaskBoardEntity(loggerFactory)
        {
            Tasks = [.. await unitOfWork.TaskRepository.ListByPageAsync(request.Page, request.PageSize)]
        };
        
        var response = new ListAllTaskResponse(taskBoard.Tasks);

        return response;
    }
}