using AutoMapper;
using Movies.API.DTOs;
using Movies.API.Models;

namespace Movies.API.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
        }
    }
}
