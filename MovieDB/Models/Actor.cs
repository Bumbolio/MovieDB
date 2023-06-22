using System.Text.Json.Serialization;

namespace MovieDB.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        [JsonIgnore]
        public List<Movie>? Movies { get; set; }
    }
}
