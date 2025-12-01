using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba", // Hardcoded GUID for Admin
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole
                {
                    Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb", // Hardcoded GUID for User
                    Name = "User",
                    NormalizedName = "USER"
                }
            );
        }
    }
}