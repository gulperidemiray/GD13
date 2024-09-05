using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VeriKatmani.Entities;
using Pomelo.EntityFrameworkCore.MySql;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VeriKatmani.Contexts;
public partial class GD13Context : DbContext
{
    public GD13Context()
    {

    }
    public GD13Context(DbContextOptions<GD13Context> options)
       : base(options)
    {
    }
    public virtual DbSet<Education> Education { get; set; }
    
    public virtual DbSet<profiles> profiles { get; set; }

    public virtual DbSet<Kullanici> Kullanici { get; set; }

    public virtual DbSet<Rol> Rol { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       

        modelBuilder.Entity<Kullanici>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Kullanic__3214D4A8E4527C23");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KullaniciAd)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.RolNoNavigation).WithMany(p => p.Kullanici)
                .HasForeignKey(d => d.RolNo)
                .HasConstraintName("FK__Kullanici__RolNo__398D8EEE");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.No).HasName("PK__Rol__3214D4A8FEDAF8BD");

            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        



        OnModelCreatingPartial(modelBuilder);
    }

    static readonly string connectionString2 = "Server=Gulperi-Macbook-Pro.local;UserID=root;Password=deneme123;Database=GD13";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString2, ServerVersion.AutoDetect(connectionString2));
    }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}




