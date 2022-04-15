namespace Movies.API.DTOs;

public class MovieRequestDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public decimal Ranking { get; set; }
    public int Duration { get; set; }
}
