namespace Management.Api.Controllers.V1;

[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class PostController : ControllerBase
{
    // GET
    [HttpGet(ApiRoutes.Posts.GetById)]
    public IActionResult GetById(Guid id)
    {
        return Ok();
    }
}