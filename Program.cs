using minmal_api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDto loginDTO) => {
    if (loginDTO.Email == "adm@teste.com" && loginDTO.Senha == "123456")
        return Results.Ok("Login com sucesso");
    else 
    return Results.Unauthorized();
});

app.Run();

