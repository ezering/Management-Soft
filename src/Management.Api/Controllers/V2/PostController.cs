using Management.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Management.Api.Controllers.V2;

[ApiVersion("2.0")]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiController]
public class PostController : ControllerBase
{
    // GET
    [HttpGet("{id:guid}")]
    public IActionResult GetById(Guid id)
    {
        var post = new Post()
        {
            Id = id,
            Text = "Hello Universe!"
        };
        return Ok(post);
    }
}