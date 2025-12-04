using Domain.TaskManagement;

namespace Application.Interfaces;

public interface ITaskBoardRepository
{
    Task<TaskBoardEntity> GetTaskBoardAsync(Guid id);
}