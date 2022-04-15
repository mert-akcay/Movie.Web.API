using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Movies.API.DTOs;
using Movies.API.Repositories;

namespace Movies.API.Filters;

public class NotFoundMovieFilter : ActionFilterAttribute
{
    private readonly IMovieRepository _movieRepository;

    public NotFoundMovieFilter(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }

    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var idObj = context.HttpContext.Request.RouteValues["id"];
        int id = int.Parse(idObj.ToString());
        var movieExists = await _movieRepository.GetById(id);

        if (movieExists != null)
        {
            await next.Invoke();
            return;
        }

        context.Result = new NotFoundObjectResult(ResponseDto<NoContent>.Fail($"Movie with the Id({id} not found)", 404));
    }
}