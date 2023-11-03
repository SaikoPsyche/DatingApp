using API.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddApplicationServices(builder.Configuration); // Application Service Extensions

builder.Services.AddIdentityServices(builder.Configuration); // Identity Service Extensions

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.UseAuthentication(); // Validation
app.UseAuthorization(); // Permissions

app.MapControllers();

app.Run();

