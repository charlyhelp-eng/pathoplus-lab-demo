var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "PathoPlus Lab Cloud Version Running Successfully 🚀");

app.Run();
