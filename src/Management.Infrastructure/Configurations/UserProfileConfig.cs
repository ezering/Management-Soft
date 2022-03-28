using Management.Domain.Aggregates.UserProfileAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Management.Infrastructure.Configurations;

internal class UserProfileConfig:IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.OwnsOne(userProfile => userProfile.BasicInfo);
        builder.OwnsOne(userProfile => userProfile.ContactInfo);
        builder.OwnsOne(userProfile => userProfile.AddressInfo);
    }
}