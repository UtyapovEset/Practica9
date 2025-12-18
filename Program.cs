
using Microsoft.EntityFrameworkCore;
using NormalPractica9.Models;

namespace NormalPractica9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddSwaggerGen();
            builder.Services.AddEndpointsApiExplorer();

            string connString = builder.Configuration.GetConnectionString("DefaultConnection");

            var migrationsAssembly = typeof(Program).Assembly.GetName().Name;

            builder.Services.AddDbContext<TrainingDbContext>(opt =>
                opt.UseSqlServer(connString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
