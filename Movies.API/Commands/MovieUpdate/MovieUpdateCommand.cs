using MediatR;
using Movies.API.DTOs;

namespace Movies.API.Commands.MovieUpdate;

public class MovieUpdateCommand : IRequest<ResponseDto<NoContent>>
{
    public MovieRequestDto Movie { get; set; }
}