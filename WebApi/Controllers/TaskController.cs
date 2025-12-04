using System.ComponentModel.DataAnnotations;
using Application.Interfaces;
using Application.Scenes.CreateTask;
using Application.Scenes.DeleteTask;
using Application.Scenes.ListAllTask;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    [Route("list-all-task/{boardId:guid}/{page:int}/{pageSize:int}")]
    [HttpGet(Name = "ListTasks")]
    public async IAsyncEnumerable<ListAllTaskItemViewModel> List(Guid boardId, int page, int pageSize, [FromServices] IHandler<ListAllTaskRequest, ListAllTaskResponse> listAllTaskHandler)
    {
        var request = new ListAllTaskRequest { Id = boardId, Page = page, PageSize = pageSize };
        var response = await listAllTaskHandler.HandleAsync(request, CancellationToken.None);
        var index = page * pageSize + 1;
        
        foreach (var task in response.Tasks)
        {
            yield return new ListAllTaskItemViewModel(task)
            {
                Index = index++,
            };
        };
    }

    [Route("create-task")]
    [HttpPost(Name = "CreateTask")]
    public async Task<ActionResult> CreateTask([FromBody] CreateTaskViewModel viewModel, [FromServices] IHandler<CreateTaskRequest, Guid> handler)
    {
        try
        {
            var id = await handler.HandleAsync(new CreateTaskRequest
            {
                BoardId = viewModel.Id,
                Title = viewModel.Title,
                Description = viewModel.Description
            }, CancellationToken.None);
            
            return Ok(id);
        }
        catch (Exception exception)
        {   
            return BadRequest(exception.Message);
        }
    }

    [Route("delete-task/{boardId:guid}/{taskId:guid}")]
    [HttpDelete(Name = "DeleteTask")]
    public async Task<ActionResult> DeleteTask(Guid boardId, Guid taskId, [FromServices] IHandler<DeleteTaskRequest, bool> handler)
    {
        try
        {
            await handler.HandleAsync(new DeleteTaskRequest
            {
                BoardId = boardId,
                TaskId = taskId
            }, CancellationToken.None);
            
            return Ok();
        }
        catch (Exception exception)
        {
            return BadRequest(exception.Message);
        }
    }
}