using Microsoft.AspNetCore.Mvc;
using MovieStoreb.Datalayer.Interfaces;
using MovieStoreb.Models.DTO;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMovieRepositori _movieRepositori;
        public MoviesController(ILogger<MoviesController> logger, IMovieRepositori movieRepositori)
        {
            _logger = logger;
            _movieRepositori = movieRepositori;
        }

        [HttpGet ("GetAll")]
        public IEnumerable<Movie> Get()
        {
            return _movieRepositori.GetMovies();
        }
    }
}
