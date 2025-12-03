using System.Threading.Channels;
using Application.Interfaces;
using Domain.Shared;
using Domain.TaskManagement;

namespace Infrastructure;

public class UnitOfWork(DefaultDbContext dbContext, Channel<DomainEventBase<TaskEntity>> taskEvent, ITaskRepository taskRepository) : IUnitOfWork
{
    public Channel<DomainEventBase<TaskEntity>> TaskEvents { get; } = taskEvent;
    
    public ITaskRepository TaskRepository { get; } = taskRepository;
    
    public async Task SaveChangeAsync(CancellationToken cancellationToken)
    {
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}