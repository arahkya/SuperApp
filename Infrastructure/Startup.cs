using System.Threading.Channels;
using Application.Interfaces;
using Domain.Shared;
using Domain.TaskManagement;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class Startup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<Channel<DomainEventBase<TaskEntity>>>(serviceProvider => Channel.CreateUnbounded<DomainEventBase<TaskEntity>>());
        
        services.AddScoped<ITaskBoardRepository, TaskBoardRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        
        return services;
    }
}