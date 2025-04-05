using Microsoft.Extensions.Options;
using RegistroUsuarios.Context;
using RegistroUsuarios.Interfaces;
using RegistroUsuarios.Repository;
using RegistroUsuarios.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("PermitirLocalhost",
        builder => builder.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500") // Reemplaza con el origen correcto del frontend
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSqlServer<RegistrosContext>(builder.Configuration.GetConnectionString("AppConnection"));

//Configurando el servicio Repositorio generico
builder.Services.AddScoped(typeof(IRepository<>), typeof(RepositoryService<>));

//builder.Services.AddScoped<IUsuarios, UsuarioService>();
//builder.Services.AddScoped<IPais, PaisService>();




var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("PermitirLocalhost");
app.UseAuthorization();

app.MapControllers();

app.Run();
