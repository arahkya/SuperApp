using Domain.TaskManagement;

namespace WebApi.Models;

public class ListAllTaskItemViewModel(TaskEntity task)
{
    public int Index { get; set; }
    public Guid Id { get; set; } = task.Id;
    public DateTime CreatedAt { get; set; } = task.CreatedOn;
    public string Title { get; set; } = task.Title;
}