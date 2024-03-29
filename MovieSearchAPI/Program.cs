﻿using MovieSearchAPI.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.ConfigureCors();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddHttpClient();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseCors("AllowMyLocalhost");
} else
{
    app.UseCors("AllowMyLiveApp");
}

app.UseAuthorization();

app.MapControllers();

app.Run();

