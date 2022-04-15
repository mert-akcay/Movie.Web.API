using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Commands.MovieUpdate;

public class MovieUpdateCommandHandler : IRequestHandler<MovieUpdateCommand,ResponseDto<NoContent>>
{
    private readonly IMovieRepository _movieRepository;

    public MovieUpdateCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public Task<ResponseDto<NoContent>> Handle(MovieUpdateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}