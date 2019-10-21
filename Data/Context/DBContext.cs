using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Data.Context
{
    public class DBContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        private readonly IConfiguration _configuration;

        public DBContext()
        {
        }

        public DBContext(IConfiguration configuration, DbContextOptions<DBContext> options) : base(options)
        {
            _configuration = configuration;
        }

        //I prefer to use Property instead of OfficeSupplies **shaahin
        //public virtual DbSet<OfficeSupplies> OfficeSupplies { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<SuppliesCategory> SuppliesCategories { get; set; }
        public virtual DbSet<Unit> Unit { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                b.Property(u => u.Id).HasDefaultValueSql("newsequentialid()");
            });
        }
    }
}
