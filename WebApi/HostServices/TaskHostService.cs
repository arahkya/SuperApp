using System.ComponentModel;
using System.Globalization;
using System.Threading.Channels;
using Domain.Shared;
using Domain.TaskManagement;

namespace WebApi.HostServices;

public class TaskHostService(IServiceProvider serviceProvider) : IHostedService
{
    private Channel<DomainEventBase<TaskEntity>>? _taskChannel;
    
    public Task StartAsync(CancellationToken cancellationToken)
    {
        var backgroundWorker = new BackgroundWorker();
        
        using var scope = serviceProvider.CreateScope();
        _taskChannel = scope.ServiceProvider.GetRequiredService<Channel<DomainEventBase<TaskEntity>>>();
        
        backgroundWorker.DoWork += async (sender,e) =>
        {
            await _taskChannel.Reader.WaitToReadAsync(cancellationToken);
        
            var taskDomainEvent = await _taskChannel.Reader.ReadAsync(cancellationToken);
        
            Console.WriteLine($"{DateTime.Now.ToString(new CultureInfo("en-TH"))} - {taskDomainEvent.Type.ToString()} Task {taskDomainEvent.Entity.Title}");
        };
        
        backgroundWorker.RunWorkerAsync();
        
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}