using Inkstack.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Inkstack.Api.Data;
using Inkstack.Api;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<InkstackApiContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("InkstackApiContext") ?? throw new InvalidOperationException("Connection string 'InkstackApiContext' not found.")));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPostEndpoints();

app.Run();