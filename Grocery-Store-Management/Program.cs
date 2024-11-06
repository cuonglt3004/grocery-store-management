
using Grocery_Store_Management.Extension;
using Microsoft.Extensions.Configuration;
using NLog;

namespace Grocery_Store_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            LogManager.Setup().LoadConfigurationFromFile();

            // Add services to the container.
            builder.Services.ConfigureCors();
            builder.Services.ConfigureRepositoryWrapper();
            builder.Services.ConfigureSQLServerService(builder.Configuration);
            builder.Services.ConfigureIISIntegration();
            builder.Services.ConfigureLoggerService();
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
        }
    }
}