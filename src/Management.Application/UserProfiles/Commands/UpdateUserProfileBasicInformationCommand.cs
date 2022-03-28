using MediatR;

namespace Management.Application.UserProfiles.Commands;

public class UpdateUserProfileBasicInformationCommand: IRequest
{
    public Guid UserProfileId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAddress { get; set; }
    public string Phone { get; set; }
    public DateTime DateOfBirth { get; set; }
}