using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Models.Responces
{
    public class GetDetailedMovieResponse
    {
        public Movie movie {  get; set; }       
        public List<Actor> actors { get; set; }
    }
}
