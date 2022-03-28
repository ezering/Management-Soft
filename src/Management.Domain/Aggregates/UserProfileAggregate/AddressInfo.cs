namespace Management.Domain.Aggregates.UserProfileAggregate;

public class AddressInfo
{
    public string AddressLine1 { get; private set; }
    public string AddressLine2 { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string ZipCode { get; private set; }
    public string Country { get; private set; }
    
    private AddressInfo(){}

    public static AddressInfo CreateAddressInfo(string addressLine1, string addressLine2, string city, string state, string zipCode, string country)
    {
        // TODO: ADD VALIDATION, ERROR HANDLING STRATEGIES, ERROR NOTIFICATION STRATEGIES

        return new AddressInfo
        {
            AddressLine1 = addressLine1,
            AddressLine2 = addressLine2,
            City = city,
            State = state,
            ZipCode = zipCode,
            Country = country
        };
    }
}