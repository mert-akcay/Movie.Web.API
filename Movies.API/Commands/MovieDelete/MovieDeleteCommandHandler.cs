using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Commands.MovieDelete;

public class MovieDeleteCommandHandler : IRequestHandler<MovieDeleteCommand, ResponseDto<NoContent>>
{
    private readonly IMovieRepository _movieRepository;

    public MovieDeleteCommandHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public Task<ResponseDto<NoContent>> Handle(MovieDeleteCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}