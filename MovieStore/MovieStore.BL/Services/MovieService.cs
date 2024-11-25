using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Request;

namespace MovieStore.BL.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        
        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public void AddMovie(AddMovieRequest movie)
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateMovie(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Movie? GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
