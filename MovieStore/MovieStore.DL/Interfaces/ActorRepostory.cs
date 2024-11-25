using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DL.Interfaces
{
    internal class ActorRepostory
    {
        
    internal class ActorRepository : IActorsRepository
        {
            public List<Actor> GetAllActors()
            {
                return InMemoryDb.Actors;
            }

            public void AddActors(Actor actors)
            {
                InMemoryDb.Actors.Add(actors);
            }

            public Actor? GetMovieById(int id)
            {
                return InMemoryDb.Actors
                    .FirstOrDefault(m => m.Id == id);
            }
            public void DeleteMovie(int id)
            {
                var actor = InMemoryDb.Actors.FirstOrDefault(actor => actor.Id == id);
                if (actor != null)
                {
                    InMemoryDb.Actors.Remove(actor);
                }
            }
            public void UpdateActor(Actor actors)
            {
                var movieToUpdate = InMemoryDb.Actors.FirstOrDefault(m => m.Id == actors.Id);
          
            }

        }

    }

    internal interface IActorsRepository
    {
    }
}
