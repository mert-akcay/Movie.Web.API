using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Queries.GetById;

public class MovieGetByIdQueryHandler : IRequestHandler<MovieGetByIdQuery, ResponseDto<MovieDto>>
{
    private readonly IMovieRepository _movieRepository;

    public MovieGetByIdQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<ResponseDto<MovieDto>> Handle(MovieGetByIdQuery request, CancellationToken cancellationToken)
    {
        var movie = await _movieRepository.GetById(request.Id);
        var movieDto = new MovieDto(movie);
        return ResponseDto<MovieDto>.Success(movieDto, 200);
    }
}
