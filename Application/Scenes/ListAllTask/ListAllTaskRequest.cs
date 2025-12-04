namespace Application.Scenes.ListAllTask;

public class ListAllTaskRequest
{
    public required Guid Id { get; init; }
    public int Page { get; init; }
    public int PageSize { get; init; }
}