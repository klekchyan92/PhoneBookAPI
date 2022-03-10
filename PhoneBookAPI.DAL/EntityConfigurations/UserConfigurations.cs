using PhoneBookAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PhoneBookAPI.DAL.EntityConfigurations
{
    class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.FirstName).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.LastName).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.MiddleName).HasColumnType("VARCHAR(100)");
            builder.Property(x => x.OrganizationName).HasColumnType("VARCHAR(100)");

            builder.HasMany(u => u.Emails)
                   .WithOne(e => e.User)
                   .HasForeignKey(e => e.UserId)
                   .OnDelete(DeleteBehavior.Restrict); 

            builder.HasMany(u => u.Phones)
                   .WithOne(p => p.User)
                   .HasForeignKey(p => p.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}