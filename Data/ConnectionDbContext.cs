using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiExample.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExample.Data;

public class ConnectionDbContext : DbContext
{
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }

    public ConnectionDbContext(DbContextOptions<ConnectionDbContext> options) : base(options)
    {
    }
}
