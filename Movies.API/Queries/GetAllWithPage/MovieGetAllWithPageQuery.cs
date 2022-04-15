using MediatR;
using Movies.API.DTOs;

namespace Movies.API.Queries.GetAllWithPage;

public class MovieGetAllWithPageQuery : IRequest<ResponseDto<List<MovieDto>>>
{
    public int Page { get; set; }
    public int PageSize { get; set; }

}