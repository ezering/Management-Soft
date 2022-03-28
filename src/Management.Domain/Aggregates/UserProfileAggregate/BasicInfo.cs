namespace Management.Domain.Aggregates.UserProfileAggregate;

public class BasicInfo
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    
    private BasicInfo() {}

    public static BasicInfo CreateBasicInfo(string firstName, string lastName, DateTime dateOfBirth)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES

        return new BasicInfo
        {
            FirstName = firstName,
            LastName = lastName,
            DateOfBirth = dateOfBirth
        };
    }
}