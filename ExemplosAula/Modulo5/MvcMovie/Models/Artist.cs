namespace MvcMovie.Models;

public class Artist
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Bio { get; set; }
    public string? Site { get; set; }

    public List<Movie>? Movies { get; set; }
}
