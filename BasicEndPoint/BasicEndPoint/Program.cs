var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Root Path");
app.MapGet("/downloads", () => "Download Photo!");
app.MapGet("/", () => "This is a put.");
app.MapGet("/", () => "Delete!!!!!");
app.MapGet("/", () => "Post me");

app.Run();
