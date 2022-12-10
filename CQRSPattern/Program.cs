using CQRSPattern.CommandOperation.Users;
using CQRSPattern.DataAccess.Users;
using CQRSPattern.Model;
using CQRSPattern.Repository.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<CqrspatternContext>(options
    => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersCommand, UsersCommand>();
builder.Services.AddScoped<IUsersCommandRepository, UsersCommandRepository>();
builder.Services.AddScoped<IUsersCommandDataAccess, UsersCommandDataAccess>();



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
