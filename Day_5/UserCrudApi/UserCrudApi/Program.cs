using Microsoft.EntityFrameworkCore;
using UserCrudApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("UsersDb")); // For demo; use SQL Server for production

var app = builder.Build();

app.MapControllers();
app.Run();