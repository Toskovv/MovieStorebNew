using Microsoft.AspNetCore.Mvc.ModelBinding;
using MovieStoreb.Datalayer.Interfaces;
using MovieStoreb.Datalayer.repositores;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IMovieRepositori, MovieRepositori>();
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if(app.Environment .IsDevelopment())
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
