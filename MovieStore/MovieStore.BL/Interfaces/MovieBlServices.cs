using MovieStore.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.BL.Interfaces
{
    internal class MovieBlServices : IMovieBlService
    {
        public IEnumerable<MovieView> GetDetailedMovies()
        {
            throw new NotImplementedException();
        }
       // IEnumerable<MovieBlServices>
    }
}
