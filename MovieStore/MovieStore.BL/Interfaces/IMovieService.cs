using MovieStore.Models.DTO;
using MovieStore.Models.Request;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetAllMovies();

        void AddMovie(Movie movie);
        void AddMovie(AddMovieRequest movie);
        void DeleteMovie(int id);
        void UpdateMovie(Movie movie);
        
    }
}
