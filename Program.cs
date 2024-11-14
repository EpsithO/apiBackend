using Microsoft.EntityFrameworkCore;
using MonProjet;

var builder = WebApplication.CreateBuilder(args);

// Ajouter le contexte de base de données
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), 
    new MySqlServerVersion(new Version(8, 0, 21)))); // Spécifie la version MySQL

// Ajout des autres services nécessaires pour ton application
builder.Services.AddControllers();

var app = builder.Build();

// Configure le pipeline HTTP
app.UseHttpsRedirection();
app.MapControllers();
app.Run();