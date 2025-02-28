using Microsoft.Extensions.DependencyInjection;
using PizzaApp.Services; // Make sure to include this namespace

var builder = WebApplication.CreateBuilder(args);

// Register the IPizzaService and its implementation
builder.Services.AddScoped<IPizzaService, PizzaService>();

// Add services to the container.
builder.Services.AddControllers();

// Swagger configuration (optional)
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

app.MapControllers();

app.Run();
