using Domain.TaskManagement;

namespace Application.Interfaces;

public interface ITaskRepository
{
    Task<IEnumerable<TaskEntity>> ListAllAsync();
    Task<IEnumerable<TaskEntity>> ListByPageAsync(int page, int pageSize);
    Task AddAsync(TaskEntity task);
}