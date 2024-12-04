using MovieStore.DL.Interfaces;
using MovieStore.DL.StaticDB;
using MovieStore.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DL.Repositories;
    public class ActorStaticRepository : IActorsRepository
{

    public Actor? GetActorById(int ActorId)
    {
        return InMemoryDb.Actors.FirstOrDefault(a => a.Id == ActorId);
    }
}
