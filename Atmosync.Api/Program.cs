using Microsoft.Data.SqlClient;
using Atmosync.Api.Interfaces.IRepositories;
using Atmosync.Api.Interfaces.IServices;
using Atmosync.Api.Repository;
using Atmosync.Api.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// Add services to the container.

builder.Services.AddControllers();

// Database Connection
builder.Services.AddScoped<System.Data.IDbConnection>(sp =>
    new SqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Register Services
builder.Services.AddScoped<IDHTSensorService, DHTSensorService>();
builder.Services.AddScoped<IMQ7SensorService, MQ7SensorService>();
builder.Services.AddScoped<IMQ136SensorService, MQ136SensorService>();

// Register Repositories
builder.Services.AddScoped<IDHTSensorRepository, DHTSensorRepository>();
builder.Services.AddScoped<IMQ7SensorRepository, MQ7SensorRepository>();
builder.Services.AddScoped<IMQ136SensorRepository, MQ136SensorRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
