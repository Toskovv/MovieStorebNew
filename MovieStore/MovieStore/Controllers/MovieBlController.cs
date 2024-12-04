using Mapster;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using System.Collections.Generic;
using System.Linq;

namespace MovieStore.Controllers
{
    public class MovieBlController(IMovieRepository movieRepository, IActorRepository actorRepository) : IMovieBlController, IMovieBlController1
    {
        private readonly IMovieRepository _movieRepository = movieRepository;
        private readonly IActorRepository _actorRepository = actorRepository;

        public IEnumerable<MovieView> GetMovieDetails()
        {
            var movies = _movieRepository.GetAllMovies();

            var movieViews = new List<MovieView>();
            foreach (var movie in movies)
            {

                var actors = _actorRepository.GetActorsByMovieId(movie.Id);


                var actorViews = actors.Select(static actor => new Actor
                {
                    ActorId = actor.Id,
                    ActorName = actor.Name
                }).ToList();


                var movieView = new MovieView
                {
                    MovieId = movie.Id,
                    MovieTitle = movie.Title,
                    MovieYear = movie.Year,
                    Actors = actorViews
                };


                movieViews.Add(movieView);
            }

            return movieViews;
        }
    }
}
