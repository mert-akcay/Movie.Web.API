using AutoMapper;
using MediatR;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Queries.GetAllWithPage;

public class MovieGetAllWithPageQueryHandler : IRequestHandler<MovieGetAllWithPageQuery, ResponseDto<List<MovieDto>>>
{
    private readonly IMovieRepository _movieRepository;
    private readonly IMapper _mapper;

    public MovieGetAllWithPageQueryHandler(IMovieRepository movieRepository, IMapper mapper)
    {
        _movieRepository = movieRepository;
        _mapper = mapper;
    }


    public async Task<ResponseDto<List<MovieDto>>> Handle(MovieGetAllWithPageQuery request, CancellationToken cancellationToken)
    {
        var movies = await _movieRepository.GetAllWithPage(request.Page, request.PageSize);

        return ResponseDto<List<MovieDto>>.Success(_mapper.Map<List<MovieDto>>(movies), 200);
    }
}
