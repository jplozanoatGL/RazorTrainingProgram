var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();
// TODO: Map Razor pages and add a MapGet route for "/weather-info" returning "Weather information"
app.MapRazorPages();
app.MapGet("/weather-info",  () => "Weather information");
// TODO: Run the application
app.Run();