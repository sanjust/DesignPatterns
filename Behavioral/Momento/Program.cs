using Momento.Service;
using Momento.Service.Interface;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();          // <<< ADD THIS
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IFormHistory, FormHistory>();
builder.Services.AddSingleton<IFormEditor, FormEditor>();

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
app.MapControllers();      // <<< ADD THIS (exposes /undo etc.)
app.MapRazorPages();

app.Run();

