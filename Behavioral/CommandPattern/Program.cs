using CommandPattern.CommandHandler;
using CommandPattern.Commands;
using CommandPattern.Invoker;
using CommandPattern.Services;
using CommandPattern.Services.Interface;
using Microsoft.Win32;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();

builder.Services.AddSingleton<IUserRepository, UserRepository>();

builder.Services.AddSingleton<ICommandInvoker, CommandInvoker>();

// Register Command Handlers
// Register ICommandHandler<TCommand, TResult>
builder.Services.AddSingleton<ICommandHandler<CreateUserCommand, CreateUserCommandResult>, CreateUserCommandHandler>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();
app.MapControllers();

app.Run();

