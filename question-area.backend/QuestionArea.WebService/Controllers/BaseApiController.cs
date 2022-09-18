using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace QuestionArea.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseApiController : ControllerBase
{
    private ISender? _mediator;

    protected ISender? Mediator => _mediator ??= HttpContext.RequestServices.GetService<ISender>();
}