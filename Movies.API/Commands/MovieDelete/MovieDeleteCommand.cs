using MediatR;
using Movies.API.DTOs;

namespace Movies.API.Commands.MovieDelete;

public class MovieDeleteCommand : IRequest<ResponseDto<NoContent>>
{
    public int Id { get; set; }
}