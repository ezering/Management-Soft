namespace Management.Api.Contracts.UserProfile.Responses;

public record BasicInformation
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}