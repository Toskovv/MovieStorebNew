namespace MovieService.Tests
{
    public class MovieBlServicesTests
    {

        private Mock<IMovieService> _movieService;

        private Mock<IActorRepository> _actorService;

        private List<Movie> _movie = new List<Movie>
        {
            new Movie()
            {
                Id=Guid.NewGuid().ToString(),
                Title="movie 1",
                Year=2021,
                Actors =["actor 1 ","actor 2 "]

             }
        };

        [Fact]
         public void GetDetailedMovies_ok()
        {
            //setup 
            _movieService
                .Setup(x => x.GetAllMovies()).Ret
                //.Returns(_movie);
        }
        public void Test1()
        {

        }
    }
}