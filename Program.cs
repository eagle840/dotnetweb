var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddApplicationInsightsTelemetry();

app.MapGet("/", () => "Hello World!");

app.Run();
