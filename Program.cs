using ApiCadastrarVeiculo.Data;
using ApiCadastrarVeiculo.Models;
using ApiCadastrarVeiculo.Rotas;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

var builder = WebApplication.CreateBuilder(args);
Batteries_V2.Init();

builder.Services.AddDbContext<VeiculoContext>(opt =>
opt.UseSqlite("Data Source=veiculos.db"));

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

//app.MapGet("/", () => "Para listar os veículos acessar o localhost em /api/veiculos");
app.MapGetRoutes();
app.MapPostRoutes();
app.MapDeleteRoutes(); 
app.MapPutRoutes();

app.Run();
