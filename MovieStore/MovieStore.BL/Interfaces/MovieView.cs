namespace MovieStore.BL.Interfaces
{
    public class MovieView
    {
        public string MovieTitle { get; set; }
        public int MovieId { get; set; }
        public int MovieYear { get; set; }
        public object Actors { get; set; }
    }
}