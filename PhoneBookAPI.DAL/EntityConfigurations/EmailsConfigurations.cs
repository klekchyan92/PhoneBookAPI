using PhoneBookAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PhoneBookAPI.DAL.EntityConfigurations
{
    class EmailsConfigurations : IEntityTypeConfiguration<Emails>
    {

        public void Configure(EntityTypeBuilder<Emails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.UserId).HasColumnType("int");
            builder.Property(x => x.IsMain).HasColumnType("boolean");
            builder.Property(x => x.Email).HasColumnType("VARCHAR(100)");
        }
    }
}