﻿using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model;

public class CrimesContext:DbContext
{
    public CrimesContext(DbContextOptions<CrimesContext> context): base(context)
    {
    }

    public DbSet<Aircraft> Aircrafts { get; set; }
    public DbSet<AircraftCrewJT> AircraftCrewJT { get; set; }
    public DbSet<AircraftSpecification> AircraftSpecifications { get; set; }
    public DbSet<Compartment> Compartments { get; set; }
    public DbSet<CrimeSyndicate> CrimeSyndicates { get; set; }
    public DbSet<EnergySystem> EnergySystems { get; set; }
    public DbSet<EnvironmentalSystem> EnvironmentalSystems { get; set; }
    public DbSet<Machinery> Machineries { get; set; }
    public DbSet<Mercenary> Mercenaries { get; set; }
    public DbSet<MercenaryReputation> MercenaryReputations { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(c => c.Syndicate)
            .WithMany()
            .HasForeignKey(c => c.SyndicateId);
        
        modelBuilder.Entity<MercenaryReputation>()
            .HasOne(m => m.Mercenary)
            .WithMany()
            .HasForeignKey(m => m.Mercenary_Id);

        modelBuilder.Entity<MercenaryReputation>()
            .HasKey(m => new { m.Mercenary_Id, m.SyndicateId });
        
        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(a => a.Aircraft)
            .WithMany()
            .HasForeignKey(a => a.Aircraft_Id);
        
        modelBuilder.Entity<AircraftCrewJT>()
            .HasOne(m => m.Mercenary)
            .WithMany()
            .HasForeignKey(m => m.Mercenary_Id);

        modelBuilder.Entity<AircraftCrewJT>()
            .HasKey(c => new { c.Aircraft_Id, c.Mercenary_Id });
        
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