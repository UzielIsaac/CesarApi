var builder = WebApplication.CreateBuilder(args);

// Registrar los controladores
builder.Services.AddControllers();

var app = builder.Build();

// Activar las rutas de los controladores
app.MapControllers();

app.Run();


