using Application.Interfaces;
using Application.Scenes.CreateTask;
using Application.Scenes.ListAllTask;
using Microsoft.Extensions.DependencyInjection;

namespace Application;

public static class Startup
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IHandler<ListAllTaskRequest, ListAllTaskResponse>, ListAllTaskHandler>();
        services.AddScoped<IHandler<CreateTaskRequest, Guid>, CreateTaskHandler>();
        
        return services;
    }
}