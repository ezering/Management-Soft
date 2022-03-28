using AutoMapper;
using Management.Api.Contracts.UserProfile.Requests;
using Management.Api.Contracts.UserProfile.Responses;
using Management.Application.UserProfiles.Commands;
using Management.Domain.Aggregates.UserProfileAggregate;

namespace Management.Api.MappingProfiles;

public class UserProfileMappings: Profile
{
    public UserProfileMappings()
    {
        CreateMap<UserProfileCreate, CreateUserCommand>();
        CreateMap<UserProfileUpdate, UpdateUserProfileBasicInformationCommand>();
        CreateMap<UserProfile, UserProfileResponse>();
        CreateMap<BasicInfo, BasicInformation>();
    }
}