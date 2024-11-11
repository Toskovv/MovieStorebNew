using MovieStoreb.Models.DTO;

namespace MovieStoreb.Datalayer.Interfaces
{
    public interface IMovieRepositori
    {
        List<Movie> GetAllMovies();
        void AddMovie(Movie movie);
    }
}