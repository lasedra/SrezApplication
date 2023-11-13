using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SrezApp.Models;

public partial class SrezdbContext : DbContext
{
    public readonly static SrezdbContext db = new();
    public SrezdbContext()
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Order> ORDER { get; set; }

    public virtual DbSet<Service> SERVICE { get; set; }

    public virtual DbSet<User> USER { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;Database=srezdb;UserName=postgres;Password=password");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.user_id).HasName("User_pkey");

            entity.ToTable("USER");

            entity.HasIndex(e => e.LOGIN, "User_login_key").IsUnique();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
