using MediatR;

namespace Management.Application.UserProfiles.Commands;

public class DeleteUserProfileCommand: IRequest
{
    public Guid UserProfileId { get; set; }
}