using Licenta2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Licenta2.Services
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var client = new IdentityRole("client");
            client.NormalizedName = "client";

            var seller = new IdentityRole("seller");
            seller.NormalizedName = "seller";

            builder.Entity<IdentityRole>().HasData(admin, client, seller);
        }

        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<AppointmentTime> AppointmentTime { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<AppointmentServices> AppointmentsServices { get; set;}

        public DbSet<Week> Weeks { get; set; }
        public DbSet<Day>  Days { get; set; }
    }
}
