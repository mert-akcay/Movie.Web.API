using MediatR;
using Movies.API.DTOs;
using Movies.API.Models;

namespace Movies.API.Queries.GetById
{
    public class MovieGetByIdQuery : IRequest<ResponseDto<MovieDto>>
    {
        public int Id { get; set; }
    }
}
