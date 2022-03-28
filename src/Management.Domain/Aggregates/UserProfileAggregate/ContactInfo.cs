namespace Management.Domain.Aggregates.UserProfileAggregate;

public class ContactInfo
{
    public string Email { get; private set; }
    public string Phone { get; private set; }
    
    private ContactInfo () {}
    
    public static  ContactInfo CreateContactInfo(string email, string phone)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES

        return new ContactInfo
        {
            Email = email,
            Phone = phone
        };
        
    }
}