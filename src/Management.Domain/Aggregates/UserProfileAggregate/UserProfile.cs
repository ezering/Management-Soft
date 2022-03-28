namespace Management.Domain.Aggregates.UserProfileAggregate;

public class UserProfile
{
    public Guid UserProfileId { get; private set; }
    public string IdentityId { get; private set; }
    public BasicInfo BasicInfo { get; private set; }
    public AddressInfo? AddressInfo { get; private set; }
    public ContactInfo? ContactInfo { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime LastModified { get; private  set; }
    
    private UserProfile() {}
    
    
    // Factory Method
    public static UserProfile CreateUserProfile(
        string identityId, 
        BasicInfo basicInfo, 
        AddressInfo addressInfo, 
        ContactInfo contactInfo
        )
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES
        return new UserProfile
        {
            UserProfileId = Guid.NewGuid(),
            IdentityId = identityId,
            BasicInfo = basicInfo,
            AddressInfo = addressInfo,
            ContactInfo = contactInfo,
            CreatedDate = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }
    
    public static UserProfile CreateUserProfile(string identityId, BasicInfo basicInfo)
    {
        return new UserProfile
        {
            UserProfileId = Guid.NewGuid(),
            IdentityId = identityId,
            BasicInfo = basicInfo,
            CreatedDate = DateTime.UtcNow,
            LastModified = DateTime.UtcNow
        };
    }
    
    // public methods
    public void UpdateBasicInfo(BasicInfo newBasicInfo)
    {
        BasicInfo = newBasicInfo;
        LastModified = DateTime.UtcNow;
    }
    
    public void UpdateAddressInfo(AddressInfo newAddressInfo)
    {
        AddressInfo = newAddressInfo;
        LastModified = DateTime.UtcNow;
    }
    
    public void UpdateContactInfo(ContactInfo newContactInfo)
    {
        ContactInfo = newContactInfo;
        LastModified = DateTime.UtcNow;
    }

    
}