using JwtMusic.Application.Interfaces;
using JwtMusic.Application.Interfaces.MusicInterfaces;
using JwtMusic.Application.Services;
using JwtMusic.Application.Tools;
using JwtMusic.Persistence.Context;
using JwtMusic.Persistence.Repositories;
using JwtMusic.Persistence.Repositories.MusicRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience, // Dinleyici
        ValidIssuer = JwtTokenDefaults.ValidIssuer, // Yayıncı
        ClockSkew = TimeSpan.Zero,//Tokenın başlangıç noktasını sıfırlama
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)), //kullanıcının sayfayı açması için sahip olması gereken key 16 karakter istiyor.
        ValidateLifetime = true, //Tokenın ayakta kalma zamanı
        ValidateIssuerSigningKey = true,
    };
});

builder.Services.AddScoped<JwtMusicContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IMusicRepository), typeof(MusicRepository));

builder.Services.AddApplicationService(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
