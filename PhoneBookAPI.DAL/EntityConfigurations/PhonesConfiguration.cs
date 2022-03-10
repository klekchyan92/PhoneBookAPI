using PhoneBookAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PhoneBookAPI.DAL.EntityConfigurations
{
    class PhonesConfiguration : IEntityTypeConfiguration<Phones>
    {
        public void Configure(EntityTypeBuilder<Phones> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.UserId).HasColumnType("int");
            builder.Property(x => x.IsMain).HasColumnType("boolean");
            builder.Property(x => x.PhoneNumber).HasColumnType("VARCHAR(100)");
        }
    }
}