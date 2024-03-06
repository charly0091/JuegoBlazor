using JuegoBlazor.Repositorio.DBContext;
using Microsoft.EntityFrameworkCore;

using JuegoBlazor.Repositorio.Contrato;
using JuegoBlazor.Repositorio.Implementacion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<L2testGame2Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddTransient(typeof(IGenericoRepositorio<>), typeof(GenericoRepositorio<>));
builder.Services.AddScoped<IRaceRepositorio, RaceRepositorio>();
builder.Services.AddScoped<ISubRaceRepositorio, SubRaceRepositorio>();
builder.Services.AddScoped<IClassRepositorio, ClassRepositorio>();
builder.Services.AddScoped<IStatBonusRepositorio, StatBonusRepositorio>();

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
