using MediatR;
using Microsoft.AspNetCore.Mvc;
using Movies.API.Commands.MovieCreate;
using Movies.API.Commands.MovieDelete;
using Movies.API.Commands.MovieUpdate;
using Movies.API.DTOs;
using Movies.API.Queries.GetAll;
using Movies.API.Queries.GetAllWithPage;

namespace Movies.API.Controllers;

public class MovieController : CustomBaseController
{
    private readonly IMediator _mediator;

    public MovieController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _mediator.Send(new MovieGetAllQuery());
        return CreateActionResult(response);
    }

    [HttpGet("pages/{page}/{pagesize}")]
    public async Task<IActionResult> GetAllWithPage(int page, int pagesize)
    {
        var response = await _mediator.Send(new MovieGetAllWithPageQuery() { Page = page, PageSize = pagesize });
        return CreateActionResult(response);
    }

    [HttpPost]
    public async Task<IActionResult> Save(MovieRequestDto movie)
    {
        var response = await _mediator.Send(new MovieInsertCommand() { Movie = movie });
        return CreateActionResult(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update(MovieRequestDto movie)
    {
        var response = await _mediator.Send(new MovieUpdateCommand() { Movie = movie });
        return CreateActionResult(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var response = await _mediator.Send(new MovieDeleteCommand() { Id = id });
        return CreateActionResult(response);
    }
}