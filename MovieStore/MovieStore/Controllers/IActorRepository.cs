
namespace MovieStore.Controllers
{
    public interface IActorRepository
    {
        IEnumerable<object> GetActorsByMovieId(int id);
    }
}