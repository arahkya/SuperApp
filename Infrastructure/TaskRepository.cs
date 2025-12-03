using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TaskRepository(DefaultDbContext dbContext) : ITaskRepository
{
    public async Task<IEnumerable<TaskEntity>> ListAllAsync()
    {
        return await dbContext.Tasks.ToListAsync();
    }

    public async Task<IEnumerable<TaskEntity>> ListByPageAsync(int page, int pageSize)
    {
        return await dbContext.Tasks.Skip(page * pageSize).Take(pageSize).ToListAsync();
    }

    public async Task AddAsync(TaskEntity task)
    {
        await dbContext.Tasks.AddAsync(task);
    }
}