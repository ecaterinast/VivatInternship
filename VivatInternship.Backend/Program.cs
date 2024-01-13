using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Reflection;
using VivatInternship.Backend.Authorization;
using VivatInternship.Backend.Data.DbModel;
using VivatInternship.Backend.Helpers;
using VivatInternship.Backend.Initialization;
using VivatInternship.Backend.Interfaces;
using VivatInternship.Backend.Services;

public class Program
{
    public static void Main(string[] args)
    {
        DbInitialiser.ApplyMigrations<BasketContext>("Server =.; Database = ShopDB; Trusted_Connection = True; TrustServerCertificate = True;");

        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddHttpClient("basket");
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<BasketContext>(options => options.UseSqlServer("Server=.;Database=ShopDB;Trusted_Connection=True;TrustServerCertificate=True;", sqlOptions =>
        {
            sqlOptions.MigrationsAssembly(typeof(Program).GetTypeInfo().Assembly.GetName().Name);
            sqlOptions.EnableRetryOnFailure(
              maxRetryCount: 3,
              maxRetryDelay: TimeSpan.FromSeconds(30),
              errorNumbersToAdd: null);
        }));
        builder.Services.AddCors();
        builder.Services.AddMvc();
        builder.Services.AddAutoMapper(typeof(Program));
        // configure strongly typed settings object
        builder.Services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));

        // configure DI for application services
        builder.Services.AddScoped<IJwtUtils, JwtUtils>();
        builder.Services.AddScoped<IUserService, UserService>();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();
        app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

        // global error handler
        app.UseMiddleware<ErrorHandlerMiddleware>();

        // custom jwt auth middleware
        app.UseMiddleware<JwtMiddleware>();

        app.MapControllers();
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}