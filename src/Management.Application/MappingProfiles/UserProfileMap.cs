using AutoMapper;
using Management.Application.UserProfiles.Commands;
using Management.Domain.Aggregates.UserProfileAggregate;

namespace Management.Application.MappingProfiles;

internal class UserProfileMap: Profile
{
    public UserProfileMap()
    {
        CreateMap<CreateUserCommand, BasicInfo>();
    }
}