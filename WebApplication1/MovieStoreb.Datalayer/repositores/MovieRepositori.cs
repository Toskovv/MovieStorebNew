using MovieStoreb.Datalayer.DB;
using MovieStoreb.Datalayer.Interfaces;
using MovieStoreb.Models.DTO;

namespace MovieStoreb.Datalayer.repositores
{
    public class MovieRepositori : IMovieRepositori
    {
        public void AddMovie(Movie movie)
        {
            StaticData.Movies.Add(movie);
        }


        public List<Movie> GetAllMovies()
        {
            return StaticData.Movies;



        }
    }
}
