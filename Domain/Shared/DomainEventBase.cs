using Domain.Interfaces;

namespace Domain.Shared;

public abstract class DomainEventBase<TSource>(TSource sourceEntity) where TSource : IEntity
{
    public enum EventType { Added, Deleted, Updated }
    
    public TSource Entity { get; init; } = sourceEntity;

    public EventType Type { get; init; }
}