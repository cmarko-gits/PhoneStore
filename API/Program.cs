using API.Data;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

// Registruj DbContext
builder.Services.AddDbContext<StoreContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registruj kontrolere
builder.Services.AddControllers();

// Registruj Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktiviraj Swagger UI
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

// Pozivanje inicijalizacije podataka
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<StoreContext>();
    var initializer = new Initialization(context);
    initializer.Initialize();
}

// Mapiranje kontrolera
app.MapControllers();

app.Run();
