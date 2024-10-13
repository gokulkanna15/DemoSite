using System;
using System.Collections.Generic;
using Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure;

public partial class DemoDbContext : DbContext
{

    public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LocationDetail> LocationDetails { get; set; }

    public virtual DbSet<WeatherDatum> WeatherData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LocationDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Location_Details");

            entity.Property(e => e.City)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Country)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");
        });

        modelBuilder.Entity<WeatherDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Weather_Data");

            entity.Property(e => e.Address)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("address");
            entity.Property(e => e.DateTime)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("date_time");
            entity.Property(e => e.Latitude)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("longitude");
            entity.Property(e => e.Maxt)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("maxt");
            entity.Property(e => e.Mint)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("mint");
            entity.Property(e => e.Precip)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("precip");
            entity.Property(e => e.Pressure)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("pressure");
            entity.Property(e => e.Temperature)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("temperature");
            entity.Property(e => e.Wdir)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("wdir");
            entity.Property(e => e.Wgust)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("wgust");
            entity.Property(e => e.Wspd)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("wspd");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
