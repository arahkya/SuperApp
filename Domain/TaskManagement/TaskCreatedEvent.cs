using Domain.Interfaces;
using Domain.Shared;

namespace Domain.TaskManagement;

public class TaskCreatedEvent(TaskEntity entity) : DomainEventBase<TaskEntity>(entity)
{
}