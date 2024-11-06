using MovieStoreb.Models.DTO;

namespace MovieStoreb.Datalayer.Interfaces
{
    public interface IMovieRepositori
    {
        List<Movie> GetMovies();
    }
}