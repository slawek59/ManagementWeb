using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Management.Data.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2a3fd4a3-351c-a41e-3443-a8a0aa6ed10f",
                    UserId = "d739e4f4-76e9-4ba9-918b-8768753cff65"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "3a6fd4a3-e51c-14a5-3d4e-1fa01a6e410f",
                    UserId = "2a3564a4-ef1a-4a1f-83e0-d3d022f3da0f"
                }
            );
        }
    }
}