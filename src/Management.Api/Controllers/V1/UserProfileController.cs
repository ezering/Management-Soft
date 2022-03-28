using AutoMapper;
using Management.Api.Contracts.UserProfile.Requests;
using Management.Api.Contracts.UserProfile.Responses;
using Management.Application.UserProfiles.Commands;
using Management.Application.UserProfiles.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Management.Api.Controllers.V1;


[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
[ApiController]
public class UserProfilesController : Controller
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public UserProfilesController(IMediator mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAllProfiles()
    {
        var query = new GetAllUserProfiles();
        var result = await _mediator.Send(query);
        var profiles = _mapper.Map<List<UserProfileResponse>>(result);
        return Ok(profiles);
    }
    
    [HttpPost]
    public async Task<IActionResult> CreateProfile(UserProfileCreate profile)
    {
       var command = _mapper.Map<CreateUserCommand>(profile);
       var response = await _mediator.Send(command);
       var userProfile= _mapper.Map<UserProfileResponse>(response);
       return CreatedAtAction(nameof(GetProfileById), new { id = userProfile.UserProfileId }, userProfile);
    }
    
    [HttpGet(ApiRoutes.UserProfiles.IdRoute)]
    public async Task<IActionResult> GetProfileById(string id)
    {
        var query = new GetUserProfileById{UserProfileId = Guid.Parse(id)};
        var result = await _mediator.Send(query);
        var userProfile = _mapper.Map<UserProfileResponse>(result);
        return Ok(userProfile);
    }
    
    [HttpPatch(ApiRoutes.UserProfiles.IdRoute)]
    public async Task<IActionResult> UpdateProfile(string id, UserProfileUpdate updatedProfile)
    {
        var command = _mapper.Map<UpdateUserProfileBasicInformationCommand>(updatedProfile);
        command.UserProfileId = Guid.Parse(id);
        var response = await _mediator.Send(command);

        return NoContent();
    }
    
    [HttpDelete(ApiRoutes.UserProfiles.IdRoute)]
    public async Task<IActionResult> DeleteProfile(string id)
    {
        var command = new DeleteUserProfileCommand{UserProfileId = Guid.Parse(id)};
        await _mediator.Send(command);
        return NoContent();
    }
    
}