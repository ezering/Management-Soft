using System.ComponentModel.DataAnnotations;

namespace Management.Api.Contracts.UserProfile.Requests;

public record UserProfileUpdate
{
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string FirstName { get; set; }
        
    [Required]
    [MinLength(3)]
    [MaxLength(50)]
    public string LastName { get; set; }
        
    [EmailAddress]
    [Required]
    public string EmailAddress { get; set; }
        
    public string PhoneNumber { get; set; }
        
    [Required]
    public DateTime DateOfBirth { get; set; }
}