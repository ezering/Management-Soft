using Management.Domain.Aggregates.UserProfileAggregate;
using MediatR;

namespace Management.Application.UserProfiles.Queries;

public class GetAllUserProfiles: IRequest<IEnumerable<UserProfile>>
{
}