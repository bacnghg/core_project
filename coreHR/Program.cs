using Microsoft.EntityFrameworkCore;
using coreHR.Models;
using coreHR.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ProductDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductDB")
    ));

builder.Services.AddTransient<IUserRepository, UserRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();



// Nuget install:
// EFCore
// EFCore.Design
// EFCore.Relational
// EFCore.SqlServer
// EFCore.Tool
// => migrate
// Tool Servername: ussing Microsoft SQL Server Management Studio // install

// Then done, using Tools => Nuget Package Manager => Package Manager Console => running: add-migration InitialMigrate => build file migratate file, run: update-database