var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
app.MapRazorPages();
app.MapGet("/custom-route", () => "Custom route response");
app.MapGet("/status", () => "Service is running");
app.Run();