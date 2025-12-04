using Application.Interfaces;
using Domain.TaskManagement;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class TaskBoardRepository(DefaultDbContext defaultDbContext) : ITaskBoardRepository
{
    public async Task<TaskBoardEntity> GetTaskBoardAsync(Guid id)
    {
        return await defaultDbContext.TaskBoards.Include(p => p.Tasks).SingleAsync(p => p.Id == id);
    }
}