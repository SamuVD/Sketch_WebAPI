using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExample.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Owner> Owners { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // Este método OnModelCreating lo utilizamos para hacer las validaciones de las propiedades.
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     // ESTO ES FLUENT API.
    //     modelBuilder.Entity<Vehicle>(vehicle =>
    //     {
    //         vehicle.ToTable("vehicles");
    //         vehicle.Property(v => v.Id).ValueGeneratedOnAdd();
    //         vehicle.Property(v => v.Brand).HasMaxLength(100).IsRequired();
    //         vehicle.Property(v => v.Model).HasMaxLength(50).IsRequired();
    //         vehicle.Property(v => v.Year).HasMaxLength(4).IsRequired();
    //         vehicle.Property(v => v.Color).HasMaxLength(80).IsRequired();
    //         vehicle.Property(v => v.TypeOfVehicle).HasMaxLength(100).IsRequired();
    //         vehicle.Property(v => v.OwnerId).IsRequired();

    //         vehicle.HasOne(v => v.Owner) // Relación de uno a muchos
    //             .WithMany(o => o.Vehicles) // Colección de vehicles en Owner
    //             .HasForeignKey(v => v.OwnerId); // Clave foránea en Vehicle
    //     });
    // }
}
