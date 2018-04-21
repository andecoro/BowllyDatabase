using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BowllyForever.Models
{
    public partial class EF_BowllyContext : DbContext
    {
        public virtual DbSet<Cassette> Cassette { get; set; }
        public virtual DbSet<Cd> Cd { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Vinyl> Vinyl { get; set; }

        public EF_BowllyContext(DbContextOptions<EF_BowllyContext> options)
          : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cassette>(entity =>
            {
                entity.ToTable("cassette");

                entity.Property(e => e.CassetteId)
                    .HasColumnName("CassetteID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist).HasMaxLength(50);

                entity.Property(e => e.CatNo)
                    .HasColumnName("Cat_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.RecordCo)
                    .HasColumnName("Record_Co")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Cd>(entity =>
            {
                entity.ToTable("cd");

                entity.Property(e => e.Cdid)
                    .HasColumnName("CDID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist).HasMaxLength(50);

                entity.Property(e => e.CatNo)
                    .HasColumnName("Cat_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.RecordCo)
                    .HasColumnName("Record_Co")
                    .HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable("track");

                entity.Property(e => e.TrackId)
                    .HasColumnName("TrackID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist).HasMaxLength(255);

                entity.Property(e => e.CatNo)
                    .HasColumnName("Cat_No")
                    .HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Label).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.Matrix).HasMaxLength(50);

                entity.Property(e => e.Music).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.Property(e => e.Words).HasMaxLength(50);
            });

            modelBuilder.Entity<Vinyl>(entity =>
            {
                entity.ToTable("vinyl");

                entity.Property(e => e.VinylId)
                    .HasColumnName("VinylID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Artist).HasMaxLength(50);

                entity.Property(e => e.CatNo)
                    .HasColumnName("Cat_No")
                    .HasMaxLength(50);

                entity.Property(e => e.Label).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.RecordCo)
                    .HasColumnName("Record_Co")
                    .HasMaxLength(50);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Year).HasColumnType("nchar(10)");
            });
        }
    }
}
