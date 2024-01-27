using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SecimIstatistikveGrafikSistemi.Models
{
    public partial class SecimDbContext : DbContext
    {
        public SecimDbContext()
        {
        }

        public SecimDbContext(DbContextOptions<SecimDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ilce> Ilces { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=UMUR;Database=SecimDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ilce>(entity =>
            {
                entity.ToTable("Ilce");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Aparti).HasColumnName("AParti");

                entity.Property(e => e.Bparti).HasColumnName("BParti");

                entity.Property(e => e.Cparti).HasColumnName("CParti");

                entity.Property(e => e.Dparti).HasColumnName("DParti");

                entity.Property(e => e.Eparti).HasColumnName("EParti");

                entity.Property(e => e.IlceAd).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
