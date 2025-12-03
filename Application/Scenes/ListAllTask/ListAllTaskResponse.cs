using Domain.TaskManagement;

namespace Application.Scenes.ListAllTask;

public class ListAllTaskResponse(IEnumerable<TaskEntity> tasks)
{
    public IEnumerable<TaskEntity> Tasks { get; internal set; } = tasks;
}