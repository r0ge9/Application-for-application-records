using System;
using System.Collections.Generic;
using DiplomApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace DiplomApp;

public partial class DiplomdbContext : DbContext
{
    public DiplomdbContext()
    {
    }

    public DiplomdbContext(DbContextOptions<DiplomdbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Domain.Application> Applications { get; set; }

    public virtual DbSet<Byro> Byros { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=diplomdb;AttachDbFilename=|DataDirectory|\\Data\\diplomdb.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    /*optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=diplomdb");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasIndex(e => e.ByroId, "IX_Admins_ByroId");

            entity.Property(e => e.Fio).HasColumnName("FIO");

            entity.HasOne(d => d.Byro).WithMany(p => p.Admins).HasForeignKey(d => d.ByroId);
        });

        modelBuilder.Entity<Domain.Application>(entity =>
        {
            entity.HasIndex(e => e.AdminId, "IX_Applications_AdminId");

            entity.HasIndex(e => e.UserId, "IX_Applications_UserId");

            entity.HasOne(d => d.Admin).WithMany(p => p.Applications).HasForeignKey(d => d.AdminId);

            entity.HasOne(d => d.User).WithMany(p => p.Applications).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Fio).HasColumnName("FIO");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    public override void Dispose()
    {
        base.Dispose();
    }
    public override ValueTask DisposeAsync()
    {
        return base.DisposeAsync();
    }
}
