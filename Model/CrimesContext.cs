using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model;

public class CrimesContext:DbContext
{
    public CrimesContext(DbContextOptions<CrimesContext> context): base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(c => c.Syndicate)
            .WithMany()
            .HasForeignKey(c => c.SyndicateId);
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(m => m.Mercenary)
            .WithMany()
            .HasForeignKey(m => m.MercenaryId);
        
        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(a => a.Aircraft)
            .WithMany()
            .HasForeignKey(a => a.AircraftId);
        
        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(m => m.Mercenary)
            .WithMany()
            .HasForeignKey(m => m.MercenaryId);
        
        modelBuilder.Entity<Aircraft>()
            .HasOne(s => s.Specification)
            .WithMany(a => a.Aircrafts)
            .HasForeignKey(s => s.SpecificationId);
        
        modelBuilder.Entity<Compartment>()
            .HasOne(a => a.Aircraft)
            .WithMany(a => a.Compartments)
            .HasForeignKey(a => a.AircraftId);
        
        modelBuilder.Entity<Machinery>()
            .HasOne<Compartment>(m => m.Compartment)
            .WithMany(c => c.Machineries)
            .HasForeignKey(m => m.CompartmentId);
        
        modelBuilder.Entity<Machinery>()
            .HasOne<Weapon>()
            .WithOne(w => w.Machinery)
            .HasForeignKey<Weapon>(w => w.MachineryId);
        
        modelBuilder.Entity<Machinery>()
            .HasOne<EnergySystem>()
            .WithOne(w => w.Machinery)
            .HasForeignKey<EnergySystem>(w => w.MachineryId);
        
        modelBuilder.Entity<Machinery>()
            .HasOne<EnvironmentalSystem>()
            .WithOne(e => e.Machinery)
            .HasForeignKey<EnvironmentalSystem>(e => e.MachineryId);
    }
}