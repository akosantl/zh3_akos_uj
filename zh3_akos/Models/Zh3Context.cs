using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace zh3_akos.Models;

public partial class Zh3Context : DbContext
{
    public Zh3Context()
    {
    }

    public Zh3Context(DbContextOptions<Zh3Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Rendelések> Rendeléseks { get; set; }

    public virtual DbSet<Szállítók> Szállítóks { get; set; }

    public virtual DbSet<Termékek> Termékeks { get; set; }

    public virtual DbSet<Vevők> Vevőks { get; set; }

    public virtual DbSet<Vásárlások> Vásárlásoks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=softwerzh3.database.windows.net;Initial Catalog=zh3;User ID=hallgato;Password=Password123");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Rendelések>(entity =>
        {
            entity.HasKey(e => e.RendelésId).HasName("PK__Rendelés__E0F991DAB6280377");

            entity.ToTable("Rendelések");

            entity.Property(e => e.RendelésId)
                .ValueGeneratedNever()
                .HasColumnName("RendelésID");
            entity.Property(e => e.RendelésDátuma).HasColumnType("date");
            entity.Property(e => e.SzállításDátuma).HasColumnType("date");
            entity.Property(e => e.SzállítóId).HasColumnName("SzállítóID");
            entity.Property(e => e.TermékId).HasColumnName("TermékID");

            entity.HasOne(d => d.Szállító).WithMany(p => p.Rendeléseks)
                .HasForeignKey(d => d.SzállítóId)
                .HasConstraintName("FK__Rendelése__Száll__60A75C0F");

            entity.HasOne(d => d.Termék).WithMany(p => p.Rendeléseks)
                .HasForeignKey(d => d.TermékId)
                .HasConstraintName("FK__Rendelése__Termé__619B8048");
        });

        modelBuilder.Entity<Szállítók>(entity =>
        {
            entity.HasKey(e => e.SzállítóId).HasName("PK__Szállító__A72B6CC389DC3077");

            entity.ToTable("Szállítók");

            entity.Property(e => e.SzállítóId)
                .ValueGeneratedNever()
                .HasColumnName("SzállítóID");
            entity.Property(e => e.Név)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ország)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TevékenységTerület)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Termékek>(entity =>
        {
            entity.HasKey(e => e.TermékId).HasName("PK__Termékek__244EC36522CD562C");

            entity.ToTable("Termékek");

            entity.Property(e => e.TermékId)
                .ValueGeneratedNever()
                .HasColumnName("TermékID");
            entity.Property(e => e.Kategória)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Név)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Ár).HasColumnType("decimal(8, 2)");
        });

        modelBuilder.Entity<Vevők>(entity =>
        {
            entity.HasKey(e => e.VevőId).HasName("PK__Vevők__AC6ED5E9E192811A");

            entity.ToTable("Vevők");

            entity.Property(e => e.VevőId)
                .ValueGeneratedNever()
                .HasColumnName("VevőID");
            entity.Property(e => e.Cím)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Név)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefonszám)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Vásárlások>(entity =>
        {
            entity.HasKey(e => e.VásárlásId).HasName("PK__Vásárlás__4B2F8C4194C10FEC");

            entity.ToTable("Vásárlások");

            entity.Property(e => e.VásárlásId)
                .ValueGeneratedNever()
                .HasColumnName("VásárlásID");
            entity.Property(e => e.TermékId).HasColumnName("TermékID");
            entity.Property(e => e.VevőId).HasColumnName("VevőID");
            entity.Property(e => e.VásárlásDátuma).HasColumnType("date");

            entity.HasOne(d => d.Termék).WithMany(p => p.Vásárlásoks)
                .HasForeignKey(d => d.TermékId)
                .HasConstraintName("FK__Vásárláso__Termé__6754599E");

            entity.HasOne(d => d.Vevő).WithMany(p => p.Vásárlásoks)
                .HasForeignKey(d => d.VevőId)
                .HasConstraintName("FK__Vásárláso__VevőI__66603565");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
