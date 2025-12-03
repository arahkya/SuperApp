using System.ComponentModel.DataAnnotations;
using Application.Interfaces;
using Application.Scenes.CreateTask;
using Application.Scenes.ListAllTask;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    [Route("list-all-task/{page}/{pageSize}")]
    [HttpGet(Name = "ListTasks")]
    public async IAsyncEnumerable<ListAllTaskItemViewModel> List(int page, int pageSize, [FromServices] IHandler<ListAllTaskRequest, ListAllTaskResponse> listAllTaskHandler)
    {
        var request = new ListAllTaskRequest { Page = page, PageSize = pageSize };
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
                Title = viewModel.Title,
                Description = viewModel.Description
            }, CancellationToken.None);
            
            return Ok(id);
        }
        catch (ValidationException validationException)
        {   
            return BadRequest(validationException.Message);
        }
    }
}