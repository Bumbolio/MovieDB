namespace MovieDB.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string? Director { get; set; }
        public string? Genre { get; set; }
        public List<Actor>? Actors { get; set; } 
    }
}
