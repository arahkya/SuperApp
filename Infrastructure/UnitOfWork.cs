using System.Threading.Channels;
using Application.Interfaces;
using Domain.Shared;
using Domain.TaskManagement;

namespace Infrastructure;

public class UnitOfWork(DefaultDbContext dbContext, Channel<DomainEventBase<TaskEntity>> taskEvent, ITaskBoardRepository taskBoardRepository) : IUnitOfWork
{
    public Channel<DomainEventBase<TaskEntity>> TaskEvents { get; } = taskEvent;
    
    public ITaskBoardRepository TaskBoardRepository { get; } = taskBoardRepository;

    public async Task SaveChangeAsync(CancellationToken cancellationToken)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}