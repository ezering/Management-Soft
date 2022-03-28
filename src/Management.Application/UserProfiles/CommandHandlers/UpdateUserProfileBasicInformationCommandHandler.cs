using Management.Application.UserProfiles.Commands;
using Management.Domain.Aggregates.UserProfileAggregate;
using Management.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Management.Application.UserProfiles.CommandHandlers;

internal class UpdateUserProfileBasicInformationCommandHandler: IRequestHandler<UpdateUserProfileBasicInformationCommand>
{
    private readonly DataContext _context;

    public UpdateUserProfileBasicInformationCommandHandler(DataContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateUserProfileBasicInformationCommand request, CancellationToken cancellationToken)
    {
        var userProfile = await _context.UserProfiles
            .FirstOrDefaultAsync(userProfile => 
                userProfile.UserProfileId == request.UserProfileId, cancellationToken);
        var basicInformation = BasicInfo.CreateBasicInfo(request.FirstName, request.LastName, request.DateOfBirth);
        userProfile?.UpdateBasicInfo(basicInformation);
        if (userProfile != null) _context.UserProfiles.Update(userProfile);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}