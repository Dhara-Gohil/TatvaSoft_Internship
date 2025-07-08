var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// app.UseHttpsRedirection(); ← remove this line
app.UseAuthorization();

app.MapControllers();

app.Run();
