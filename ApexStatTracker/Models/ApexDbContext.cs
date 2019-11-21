using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApexStatTracker.Models
{
    public partial class ApexDbContext : DbContext
    {
        public ApexDbContext()
        {
        }

        public ApexDbContext(DbContextOptions<ApexDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aaron> Aaron { get; set; }
        public virtual DbSet<Brandon> Brandon { get; set; }
        public virtual DbSet<Jake> Jake { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ApexDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aaron>(entity =>
            {
                entity.HasKey(e => e.GameNumber)
                    .HasName("PK__Aaron__CEF05AADBACF41DD");
            });

            modelBuilder.Entity<Brandon>(entity =>
            {
                entity.HasKey(e => e.GameNumber)
                    .HasName("PK__Brandon__CEF05AAD23B482F7");
            });

            modelBuilder.Entity<Jake>(entity =>
            {
                entity.HasKey(e => e.GameNumber)
                    .HasName("PK__Jake__CEF05AAD364BB6C9");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
