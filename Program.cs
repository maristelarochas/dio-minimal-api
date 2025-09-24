using dio_minimal_api.Dominio.Dtos;
using dio_minimal_api.Infraestrutura.Db;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContexto>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("mysql")!,
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("mysql"))));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDto loginDto) =>
{
    if (loginDto.Email == "adm@teste.com" && loginDto.Senha == "123456")
        return Results.Ok("Login realizado com sucesso");
    else
        return Results.Unauthorized();
});

app.Run();