﻿namespace Movies.API.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public decimal Ranking { get; set; }
    public int Duration { get; set; }

}