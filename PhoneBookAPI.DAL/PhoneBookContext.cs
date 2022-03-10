using PhoneBookAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using PhoneBookAPI.DAL.EntityConfigurations;

namespace PhoneBookAPI.DAL
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Phones> Phones { get; set; }
        public DbSet<Emails> Emails { get; set; }

        public PhoneBookContext(DbContextOptions options) : base(options) 
        {
            Database.Migrate();
        }

        public PhoneBookContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new EmailsConfigurations());
            modelBuilder.ApplyConfiguration(new PhonesConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfigurations());
        }
    }
}
