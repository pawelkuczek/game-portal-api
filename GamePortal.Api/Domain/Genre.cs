namespace GamePortal.Api.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
