using MovieStore.BL;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;

namespace MovieStore
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddSingleton<IMovieService, MovieService>();
            services.AddSingleton<MovieBlService, MovieBlService>();
            services.RegisterDataLayer();
            services.RegisterBusinessLayer();
        }
    }
}
