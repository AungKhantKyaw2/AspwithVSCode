var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


var app = builder.Build();
// Configure the HTTP request pipeline.

// Remove HTTPS redirection so you can test with http

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();