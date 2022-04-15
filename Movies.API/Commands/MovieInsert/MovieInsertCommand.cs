using MediatR;
using Movies.API.DTOs;

namespace Movies.API.Commands.MovieCreate;

public class MovieInsertCommand : IRequest<ResponseDto<int>>
{
    public MovieRequestDto Movie { get; set; }
}