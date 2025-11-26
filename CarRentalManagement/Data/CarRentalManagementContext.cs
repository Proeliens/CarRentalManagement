using CarRentalManagement.Configuration.Entities;
using CarRentalManagement.Configurations.Entities;
using CarRentalManagement.Domain;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement.Data
{
    public class CarRentalManagementContext : DbContext
    {
        public CarRentalManagementContext(DbContextOptions<CarRentalManagementContext> options)
            : base(options)
        {
        }

        public DbSet<Make> Make { get; set; } = default!;
        public DbSet<Model> Model { get; set; } = default!;
        public DbSet<Colour> Colour { get; set; } = default!;
        public DbSet<Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}