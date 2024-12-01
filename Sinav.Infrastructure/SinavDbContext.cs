using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sinav.Domain;

namespace Sinav.Infrastructure
{
    public class SinavDbContext:DbContext
    {
        public readonly IConfiguration _configuration;

        public SinavDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("TestDbContext"));



            base.OnConfiguring(optionsBuilder);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User2>(entity =>
            {
            });

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User2> User { get; set; }


    }
}

