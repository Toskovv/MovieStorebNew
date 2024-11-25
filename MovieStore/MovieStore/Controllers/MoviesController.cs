using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
using MovieStore.Models.Request;
using Serilog.Core;
using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
       
        private readonly IMovieService _movieService;
        private readonly IMapper _mapper;
        private readonly ILogger<MoviesController> _logger;
        

        public MoviesController(IMovieService movieService, IMapper mapper,ILogger<MoviesController>logger)

        {
            _movieService = movieService;
            _mapper = mapper;
            _logger = logger;
    }

        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            var result = _movieService.GetAllMovies();

            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("GetById")]

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetById(int id)
            
        {
            if (id <= 0)
            {
                return BadRequest("id must be grader than 0");
            }
            var result = _movieService.GetById(id); ;
            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }
            return Ok(result);
            //return _movieService.GetById(id);
        }
        [HttpPost("Add")]
        public IActionResult Add(AddMovieRequest movie)
        {
            var movieDto = _mapper.Map<Movie>(movie);

            if (movieDto == null)
            {
                return BadRequest();
            }
            _movieService.AddMovie(movieDto);
            return Ok();
            
        }
       
        [HttpDelete("Delete")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("id must be grader than 0");
            }
            var result = _movieService.GetById(id); ;
            if (result == null)
            {
                return NotFound($"Movie with ID:{id} not found");
            }
            return Ok(result);

            //_movieService.DeleteMovie(id);
        }

        [HttpPut("Update")]
        public void Update(UpdateMovieRequest movie)
        {
            var movieDto = _mapper.Map<Movie>(movie);
            _movieService.UpdateMovie(movieDto);
        }

    }
}

