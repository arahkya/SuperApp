using Domain.Interfaces;
using Domain.Shared;

namespace Domain.TaskManagement;

public class TaskDomainEvent(TaskEntity entity) : DomainEventBase<TaskEntity>(entity)
{
}