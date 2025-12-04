namespace Application.Scenes.CreateTask;

public class CreateTaskRequest
{
    public required Guid BoardId { get; init; }
    public required string Title { get; init; }
    public string? Description { get; init; }
}