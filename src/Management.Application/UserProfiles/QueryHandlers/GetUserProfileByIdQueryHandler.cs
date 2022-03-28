using Management.Application.UserProfiles.Queries;
using Management.Domain.Aggregates.UserProfileAggregate;
using Management.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Management.Application.UserProfiles.QueryHandlers;

internal class GetUserProfileByIdQueryHandler: IRequestHandler<GetUserProfileById, UserProfile>
{
    private readonly DataContext _context;

    public GetUserProfileByIdQueryHandler(DataContext context)
    {
        _context = context;
    }

    public async Task<UserProfile> Handle(GetUserProfileById request, CancellationToken cancellationToken)
    {
        return await _context.UserProfiles.FirstOrDefaultAsync(userProfile => userProfile.UserProfileId == request.UserProfileId, cancellationToken);
    }
}