using AutoMapper;
using Management.Application.UserProfiles.Commands;
using Management.Domain.Aggregates.UserProfileAggregate;
using Management.Infrastructure;
using MediatR;

namespace Management.Application.UserProfiles.CommandHandlers;

public class CreateUserCommandHandler: IRequestHandler<CreateUserCommand, UserProfile>
{
    private readonly DataContext _context;

    public CreateUserCommandHandler( DataContext context)
    {
        _context = context;
    }
    
    public async Task<UserProfile> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var basicInfo = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.DateOfBirth);
        var userProfile = UserProfile.CreateUserProfile(Guid.NewGuid().ToString(), basicInfo);
        _context.UserProfiles.Add(userProfile);
        await _context.SaveChangesAsync(cancellationToken);
        return userProfile;
    }
}