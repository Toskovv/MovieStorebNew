using MovieStore.Models.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Responces
{
    public class GetFullMovieDetailsResponce
    {
        IEnumerable<MoviesView> MoviesView { get; set; } = [];
    }
}
