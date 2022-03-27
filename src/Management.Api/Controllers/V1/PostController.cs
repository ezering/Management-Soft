using Management.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Management.Api.Controllers.V1;

[ApiVersion("1.0")]
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
           Text = "Hello World"
        };
        return Ok(post);
    }
}