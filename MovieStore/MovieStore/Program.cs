using MovieStore.BL;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using Mapster;
using MovieStore.MapsterConfig;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using FluentValidation;
using MovieStore.Validators;
using FluentValidation.AspNetCore;
namespace MovieStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Console(theme: AnsiConsoleTheme.Code)
            .CreateLogger();

            builder.Logging.AddSerilog(logger);
            // Add services to the container.
            builder.Services
                .RegisterDataLayer()
                .RegisterBusinessLayer();


            builder.Services.AddValidatorsFromAssemblyContaining<AddMovieRequestValidator>();
            builder.Services.AddFluentValidationAutoValidation();

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMapster();
            MapsterConfiguration.Configure();
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
