using MapsterMapper;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using System.Collections.Generic;

namespace MovieStore.Controllers
{
    public class MovieBlController 
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IActorRepository _actorresponsy;
        public IEnumerable<MovieView> DetailedMovies; 
            foreach (var movie in movies)
        {
             var actors= new List<Actors>
            var movieView = new MovieView()
            {
                MovieId = Movie.Id,
                MovieTitle = Movie.Title,
                MovieYear = Movie, Year,
                Actors = new List<Actor>()
            };
        
            
            

            
        }
    }
}
