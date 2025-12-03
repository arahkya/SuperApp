using System.Threading.Channels;
using Application;
using Domain.Shared;
using Domain.TaskManagement;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using WebApi.HostServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DefaultDbContext>(p =>
{
    p.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbConnection"));
});

builder.Services.AddInfrastructure();
builder.Services.AddApplication();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddHostedService<TaskHostService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();