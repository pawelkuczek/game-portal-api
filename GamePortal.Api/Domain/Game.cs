namespace GamePortal.Api.Domain
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public DateOnly? ReleaseDate { get; set; }
        public ICollection<Genre> Genres { get; set; } = new List<Genre>();

        public ICollection<Platform> Platforms { get; set; } = new List<Platform>();
    }
}
