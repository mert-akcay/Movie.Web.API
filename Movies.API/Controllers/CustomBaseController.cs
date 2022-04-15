using Microsoft.AspNetCore.Mvc;
using Movies.API.DTOs;

namespace Movies.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomBaseController : ControllerBase
{
    [NonAction]
    public IActionResult CreateActionResult<T>(ResponseDto<T> response)
    {
        return response.StatusCode == 204
            ? new ObjectResult(null) { StatusCode = response.StatusCode }
            : new ObjectResult(response) { StatusCode = response.StatusCode };
    }
}
