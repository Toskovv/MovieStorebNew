using MovieStoreb.Models.DTO;
using System.Reflection;

namespace MovieStoreb.Datalayer.DB
{
    internal class StaticData
    {
        public static List<Movie> Movies = new List<Movie>
            {
                new Movie
                {
                    ID=1, Title="The Shawshark",Year="2020"
                },
                new Movie
                {
                    ID=2,Title="The Godfather",Year="1990"
                }
            };
    }
}
