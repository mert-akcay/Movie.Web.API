using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Queries.GetAll;

public class MovieGetAllQueryHandler : IRequestHandler<MovieGetAllQuery, ResponseDto<List<MovieDto>>>
{
    private readonly IMovieRepository _movieRepository;

    public MovieGetAllQueryHandler(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public async Task<ResponseDto<List<MovieDto>>> Handle(MovieGetAllQuery request, CancellationToken cancellationToken)
    {
        var movies = await _movieRepository.GetAll();
        var movieDtos = new List<MovieDto>();

        movies.ForEach(movie => movieDtos.Add(new MovieDto(movie)));
        return ResponseDto<List<MovieDto>>.Success(movieDtos, 200);
    }
}
