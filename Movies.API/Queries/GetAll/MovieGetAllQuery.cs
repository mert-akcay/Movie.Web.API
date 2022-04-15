using MediatR;
using Movies.API.DTOs;

namespace Movies.API.Queries.GetAll;

public class MovieGetAllQuery : IRequest<ResponseDto<List<MovieDto>>>
{

}