using Management.Application.UserProfiles.Commands;
using Management.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Management.Application.UserProfiles.CommandHandlers;

public class DeleteUserProfileCommandHandler: IRequestHandler<DeleteUserProfileCommand>
{
    private readonly DataContext _context;

    public DeleteUserProfileCommandHandler(DataContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteUserProfileCommand request, CancellationToken cancellationToken)
    {
        var userProfile = await _context.UserProfiles
            .FirstOrDefaultAsync(userProfile => userProfile.UserProfileId == request.UserProfileId, cancellationToken);
        if (userProfile == null) return Unit.Value;
        _context.UserProfiles.Remove(userProfile);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}