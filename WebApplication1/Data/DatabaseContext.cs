using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data;

public class DatabaseContext : DbContext
{
    public DbSet<AvailableProgram> AvailablePrograms { get; set; }
    public DbSet<ProgramEntity> ProgramEntities { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
    public DbSet<WashingMaschine> WashingMaschines { get; set; }
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(new List<Customer>()
        {
            new Customer() { CustomerId = 1, FirstName = "John", LastName = "Doe", PhoneNumber = null },
            new Customer() { CustomerId = 2, FirstName = "Marie", LastName = "Doew", PhoneNumber = null }

        });

        modelBuilder.Entity<AvailableProgram>().HasData(new List<AvailableProgram>()
        {
            new AvailableProgram() { AvailableProgramId = 1, WashingMachineId = 1, ProgramId = 1, Price = 10.0 },
            new AvailableProgram() { AvailableProgramId = 2, WashingMachineId = 2, ProgramId = 2, Price = 15.0 }

        });

        modelBuilder.Entity<PurchaseHistory>().HasData(new List<PurchaseHistory>()
        {
            new PurchaseHistory()
                { AvailableProgramId = 1, CustomerId = 1, PurchaseDate = DateTime.Parse("2025-07-07"), Rating = 4 },
            new PurchaseHistory()
                { AvailableProgramId = 2, CustomerId = 2, PurchaseDate = DateTime.Parse("2025-07-08"), Rating = 5 }

        });

        modelBuilder.Entity<WashingMaschine>().HasData(new List<WashingMaschine>()
        {
            new WashingMaschine() { WashingMaschineId = 1, MaxWeight = 500.0, SerialNumber = "1029351" },
            new WashingMaschine() { WashingMaschineId = 2, MaxWeight = 600.0, SerialNumber = "30251251" }

        });
        
        modelBuilder.Entity<ProgramEntity>().HasData(new List<ProgramEntity>()
        {
            new ProgramEntity() { ProgramId = 1, Name = "Washing", DurationMinutes = 60, TemperatureCelsius = 90},
            new ProgramEntity() { ProgramId = 2, Name = "Washing everything", DurationMinutes = 90, TemperatureCelsius = 60},

        });
    }
}