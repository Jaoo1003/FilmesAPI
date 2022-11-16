using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using UsuariosAPI.Controllers;
using UsuariosAPI.Data;
using UsuariosAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDbContext<UserDbContext>(options => 
    options.UseMySql(builder.Configuration.GetConnectionString("UsuarioConnection")
    , new MySqlServerVersion(new Version(8, 0))));

builder.Services.AddIdentity<IdentityUser<int>, IdentityRole<int>>(
    opt => opt.SignIn.RequireConfirmedEmail = true
    )
    .AddEntityFrameworkStores<UserDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddScoped<CadastroService, CadastroService>();
builder.Services.AddScoped<EmailService, EmailService>();
builder.Services.AddScoped<LoginService, LoginService>();
builder.Services.AddScoped<TokenService, TokenService>();
builder.Services.AddScoped<LogoutService, LogoutService>();

var app = builder.Build();

// Configure the HTTP request pipeline.


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
