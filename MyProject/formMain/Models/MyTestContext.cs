using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace MyProject.Models
{
    public partial class MyTestContext : DbContext
    {
        public MyTestContext()
        {
        }

        public MyTestContext(DbContextOptions<MyTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Mon> Mons { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<KetQua>(entity =>
            {
                entity.HasKey(e => new { e.MaSo, e.MaMh });

                entity.ToTable("KetQua");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(6)
                    .HasColumnName("MaMH")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaMhNavigation)
                    .WithMany(p => p.KetQuas)
                    .HasForeignKey(d => d.MaMh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KetQua_Mon");

                entity.HasOne(d => d.MaSoNavigation)
                    .WithMany(p => p.KetQuas)
                    .HasForeignKey(d => d.MaSo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KetQua_SinhVien");
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.MaKhoa);

                entity.ToTable("Khoa");

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.TenKhoa)
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Mon>(entity =>
            {
                entity.HasKey(e => e.MaMh);

                entity.ToTable("Mon");

                entity.Property(e => e.MaMh)
                    .HasMaxLength(6)
                    .HasColumnName("MaMH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenMh)
                    .HasMaxLength(50)
                    .HasColumnName("TenMH")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SinhVien>(entity =>
            {
                entity.HasKey(e => e.MaSo)
                    .HasName("PK__SinhVien__2725087D2C1735E8");

                entity.ToTable("SinhVien");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaKhoa)
                    .HasMaxLength(6)
                    .IsFixedLength(true);

                entity.Property(e => e.NgaySinh).HasColumnType("datetime");

                entity.HasOne(d => d.Khoas)
                    .WithMany(p => p.SinhViens)
                    .HasForeignKey(d => d.MaKhoa)
                    .HasConstraintName("FK_SinhVien_Khoa");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
