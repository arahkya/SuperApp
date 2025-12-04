namespace Application.Scenes.DeleteTask;

public class DeleteTaskRequest
{
    public Guid BoardId { get; set; }
    public Guid TaskId { get; set; }
}