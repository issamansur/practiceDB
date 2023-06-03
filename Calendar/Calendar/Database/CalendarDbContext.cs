using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Database;

public partial class CalendarDbContext : DbContext
{
    //private string PathToDB { get; init; }

    public CalendarDbContext(/*string pathToDB*/)
    {
        /*PathToDB = pathToDB;*/
    }

    public CalendarDbContext(DbContextOptions<CalendarDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Event> Events { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite($@"Data Source=CalendarDB.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.ID).HasName("PK_Event");

            entity.ToTable("Event");

            entity.Property(e => e.ID).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(20);
            entity.Property(e => e.DateStart).HasColumnType("datetime");
            entity.Property(e => e.DateEnd).HasColumnType("datetime");
            entity.Property(e => e.AllDay).HasColumnType("bit");
            entity.Property(e => e.EveryYear).HasColumnType("bit");
            entity.Property(e => e.DateRemind).HasColumnType("datetime").IsRequired(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
