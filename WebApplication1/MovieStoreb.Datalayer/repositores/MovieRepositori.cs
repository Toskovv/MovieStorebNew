using MovieStoreb.Datalayer.DB;
using MovieStoreb.Datalayer.Interfaces;
using MovieStoreb.Models.DTO;

namespace MovieStoreb.Datalayer.repositores
{
    public class MovieRepositori : IMovieRepositori
    {
        public List<Movie> GetMovies()
        {
            return StaticData.Movies;
        }
    }
}
