using System;
using System.Collections.Generic;
using CarAppMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CarAppMVC.Data;

public partial class CarAppDbContext : DbContext
{
    public CarAppDbContext()
    {
    }

    public CarAppDbContext(DbContextOptions<CarAppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<UserAccount> UserAccounts { get; set; }

    public virtual DbSet<VehicleListing> VehicleListings { get; set; }

    public virtual DbSet<WatchList> WatchLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserAcco__DED99714011E1267");
        });

        modelBuilder.Entity<VehicleListing>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__VehicleL__3214EC275671CD7B");
        });

        modelBuilder.Entity<WatchList>(entity =>
        {
            entity.HasKey(e => e.WatchlistId).HasName("PK__WatchLis__35FF92A67A07E2DC");

            entity.HasOne(d => d.Listing).WithMany(p => p.WatchLists)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WatchList_To_VehicleListing(ToTableColumn)");

            entity.HasOne(d => d.User).WithMany(p => p.WatchLists).HasConstraintName("FK_WatchList_To_UserAccount(ToTableColumn)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
