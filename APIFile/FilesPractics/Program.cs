using FilesPractics.Data;
using FilesPractics.Services;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
try
{
    // Используйте корректный формат идентификатора культуры "en-US"
    CultureInfo.CurrentCulture = new CultureInfo("en-US");
}
catch (CultureNotFoundException ex)
{
    // Обработайте исключение или зарегистрируйте ошибку
    Console.WriteLine($"Invalid culture identifier: {ex.InvalidCultureId}");
}
// Add services to the container.
builder.Services.AddDbContext<ProfileDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IProfileService, ProfileService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
