using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PortfolioV2.WebApp.Models;

namespace PortfolioV2.WebApp.Data;

public partial class PortfolioV2Context : DbContext
{
    public PortfolioV2Context()
    {
    }

    public PortfolioV2Context(DbContextOptions<PortfolioV2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=portfolio_v2"); // TODO: Update this connection string to be placed into secrets

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users_pkey");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
