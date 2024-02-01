using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DALLAYER.Models
{
    public partial class OnlineBusBookingDbContext : DbContext
    {
        public OnlineBusBookingDbContext()
        {
        }

        public OnlineBusBookingDbContext(DbContextOptions<OnlineBusBookingDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adminlogin> Adminlogins { get; set; } = null!;
        public virtual DbSet<BusInventory> BusInventories { get; set; } = null!;
        public virtual DbSet<Usersignup> Usersignups { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=LAPTOP-S16135GT;database=OnlineBusBookingDb;trusted_connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adminlogin>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__adminlog__F3DBC57386E5800E");

                entity.ToTable("adminlogin");

                entity.Property(e => e.Username)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Pswrd)
                    .HasMaxLength(90)
                    .IsUnicode(false)
                    .HasColumnName("pswrd");
            });

            

            modelBuilder.Entity<BusInventory>(entity =>
            {
                entity.HasKey(e => e.BusId)
                    .HasName("PK__BusInven__6A0F60B52125AC87");

                entity.ToTable("BusInventory");

                entity.Property(e => e.BusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AvailabilitySeats).HasColumnName("Availability_Seats");

                entity.Property(e => e.Boarding)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusCategory)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BusName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Departure)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usersignup>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__usersign__F3DBC573BB22ACEF");

                entity.ToTable("usersignup");

                entity.Property(e => e.Username)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Adress)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("adress");

                entity.Property(e => e.City)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Dob)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("fullname");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("mobile");

                entity.Property(e => e.Pincode)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("pincode");

                entity.Property(e => e.Pswrd)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("pswrd");

                entity.Property(e => e.Stat)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("stat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
