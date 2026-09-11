using Microsoft.EntityFrameworkCore;
using UsuarioApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// 1. Registrar soporte para Controladores
builder.Services.AddControllers();

// 2. Registrar AppDbContext conectándolo a SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configurar OpenAPI / Swagger
builder.Services.AddOpenApi();

var app = builder.Build();

// Coonfigurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();
