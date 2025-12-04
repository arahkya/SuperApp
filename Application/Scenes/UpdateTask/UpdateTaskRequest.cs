namespace Application.Scenes.UpdateTask;

public class UpdateTaskRequest
{
    public required Guid BoardId { get; init; }
    public required Guid TaskId { get; init; }
    public required string Title { get; init; }
    public string? Description { get; init; }
}