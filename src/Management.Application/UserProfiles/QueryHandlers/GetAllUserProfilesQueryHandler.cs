using Management.Application.UserProfiles.Queries;
using Management.Domain.Aggregates.UserProfileAggregate;
using Management.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Management.Application.UserProfiles.QueryHandlers;

internal class GetAllUserProfilesQueryHandler: IRequestHandler<GetAllUserProfiles, IEnumerable<UserProfile>>
{
    private readonly DataContext _context;

    public GetAllUserProfilesQueryHandler(DataContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<UserProfile>> Handle(GetAllUserProfiles request, CancellationToken cancellationToken)
    {
        return await _context.UserProfiles.ToListAsync(cancellationToken: cancellationToken);
    }
}