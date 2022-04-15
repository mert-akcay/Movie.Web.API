using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Movies.API.DTOs;

namespace Movies.API.Filters;

public class ValidateFilter : ActionFilterAttribute
{
    public override void OnActionExecuted(ActionExecutedContext context)
    {
        if (!context.ModelState.IsValid)
        {
            var errors = context.ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
            context.Result = new BadRequestObjectResult(ResponseDto<NoContent>.Fail(errors,400));
        }
    }
}
