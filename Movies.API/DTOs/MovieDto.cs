using Movies.API.Models;

namespace Movies.API.DTOs;

public class MovieDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public decimal Ranking { get; set; }
    public int Duration { get; set; }

    public MovieDto()
    {
        
    }

    public MovieDto(Movie movie)
    {
        Id = movie.Id;
        Title = movie.Title;
        Director = movie.Director;
        Ranking = movie.Ranking;
        Duration = movie.Duration;
    }
}