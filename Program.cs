using MiniChallenges2To4.Services.MiniChallenge2;
using MiniChallenges2To4.Services.MiniChallenge3;
using MiniChallenges2To4.Services.MiniChallenge4;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMiniChallenge2Service, MiniChallenge2Service>();
builder.Services.AddScoped<IMiniChallenge3Service, MiniChallenge3Service>();
builder.Services.AddScoped<IMiniChallenge4Service, MiniChallenge4Service>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
