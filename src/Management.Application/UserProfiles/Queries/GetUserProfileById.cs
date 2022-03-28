using Management.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace Management.Application.UserProfiles.Queries;

public class GetUserProfileById: IRequest<UserProfile>
{
    public Guid UserProfileId { get; set; }
}
