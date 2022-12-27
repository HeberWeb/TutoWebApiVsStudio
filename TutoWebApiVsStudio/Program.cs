using Microsoft.EntityFrameworkCore;
using TutoWebApiVsStudio.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Usando banco de dados na memória - "TudoList" é o nome do banco
//builder.Services.AddDbContext<TodoContext>(opt => 
//    opt.UseInMemoryDatabase("TudoList"));

//Usando banco de dados sql, valor do .GetConnectionString configurada no arquivo appsettings.json
builder.Services.AddDbContext<TodoContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("TutoWebApiDatabase")));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
