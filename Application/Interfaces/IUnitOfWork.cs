using System.Threading.Channels;
using Domain.Shared;
using Domain.TaskManagement;

namespace Application.Interfaces;

public interface IUnitOfWork
{
    public Channel<DomainEventBase<TaskEntity>> TaskEvents { get; }
    public ITaskRepository TaskRepository { get; }
    Task SaveChangeAsync(CancellationToken cancellationToken);
}