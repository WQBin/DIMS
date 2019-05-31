using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DIMS.Models.Tables
{
    public partial class dimsContext : DbContext
    {
        public dimsContext()
        {
        }

        public dimsContext(DbContextOptions<dimsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administer> Administer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Fastmail> Fastmail { get; set; }
        public virtual DbSet<Latereturn> Latereturn { get; set; }
        public virtual DbSet<Livingschool> Livingschool { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<Repairpaper> Repairpaper { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Studentbuilding> Studentbuilding { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=sql123456; database=dims;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Administer>(entity =>
            {
                entity.HasKey(e => e.Ano)
                    .HasName("PRIMARY");

                entity.ToTable("administer");

                entity.Property(e => e.Ano).HasColumnType("varchar(20)");

                entity.Property(e => e.Aname).HasColumnType("varchar(20)");

                entity.Property(e => e.Apassword).HasColumnType("varchar(20)");

                entity.Property(e => e.Atype).HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => new { e.Dno, e.Bno })
                    .HasName("PRIMARY");

                entity.ToTable("department");

                entity.HasIndex(e => e.Bno)
                    .HasName("FK_Reference_1");

                entity.Property(e => e.Dno).HasColumnType("varchar(20)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Dlivednum).HasColumnType("int(11)");

                entity.HasOne(d => d.BnoNavigation)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.Bno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_1");
            });

            modelBuilder.Entity<Fastmail>(entity =>
            {
                entity.HasKey(e => e.Fno)
                    .HasName("PRIMARY");

                entity.ToTable("fastmail");

                entity.HasIndex(e => e.Bno)
                    .HasName("FK_Reference_3");

                entity.HasIndex(e => e.Sno)
                    .HasName("FK_Reference_2");

                entity.Property(e => e.Fno).HasColumnType("int(11)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Farrivedate).HasColumnType("date");

                entity.Property(e => e.Fnum).HasColumnType("int(11)");

                entity.Property(e => e.Freceivedate).HasColumnType("date");

                entity.Property(e => e.Fstate).HasColumnType("varchar(20)");

                entity.Property(e => e.Sno).HasColumnType("varchar(20)");

                entity.HasOne(d => d.BnoNavigation)
                    .WithMany(p => p.Fastmail)
                    .HasForeignKey(d => d.Bno)
                    .HasConstraintName("FK_Reference_3");

                entity.HasOne(d => d.SnoNavigation)
                    .WithMany(p => p.Fastmail)
                    .HasForeignKey(d => d.Sno)
                    .HasConstraintName("FK_Reference_2");
            });

            modelBuilder.Entity<Latereturn>(entity =>
            {
                entity.HasKey(e => e.Lno)
                    .HasName("PRIMARY");

                entity.ToTable("latereturn");

                entity.HasIndex(e => e.Bno)
                    .HasName("FK_Reference_10");

                entity.HasIndex(e => e.Sno)
                    .HasName("FK_Reference_9");

                entity.Property(e => e.Lno).HasColumnType("int(11)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Lreason).HasColumnType("varchar(20)");

                entity.Property(e => e.Lreturntime).HasColumnType("datetime");

                entity.Property(e => e.Sno)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.BnoNavigation)
                    .WithMany(p => p.Latereturn)
                    .HasForeignKey(d => d.Bno)
                    .HasConstraintName("FK_Reference_10");

                entity.HasOne(d => d.SnoNavigation)
                    .WithMany(p => p.Latereturn)
                    .HasForeignKey(d => d.Sno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_9");
            });

            modelBuilder.Entity<Livingschool>(entity =>
            {
                entity.HasKey(e => e.Lno)
                    .HasName("PRIMARY");

                entity.ToTable("livingschool");

                entity.HasIndex(e => e.Bno)
                    .HasName("FK_Reference_6");

                entity.HasIndex(e => e.Sno)
                    .HasName("FK_Reference_5");

                entity.Property(e => e.Lno).HasColumnType("int(11)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Llivingdate).HasColumnType("date");

                entity.Property(e => e.Lreturndate).HasColumnType("date");

                entity.Property(e => e.Sno)
                    .IsRequired()
                    .HasColumnType("varchar(20)");

                entity.HasOne(d => d.BnoNavigation)
                    .WithMany(p => p.Livingschool)
                    .HasForeignKey(d => d.Bno)
                    .HasConstraintName("FK_Reference_6");

                entity.HasOne(d => d.SnoNavigation)
                    .WithMany(p => p.Livingschool)
                    .HasForeignKey(d => d.Sno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_5");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasKey(e => e.Pno)
                    .HasName("PRIMARY");

                entity.ToTable("property");

                entity.HasIndex(e => new { e.Dno, e.Bno })
                    .HasName("FK_Reference_7");

                entity.Property(e => e.Pno).HasColumnType("int(11)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Dno).HasColumnType("varchar(20)");

                entity.Property(e => e.Pname).HasColumnType("varchar(20)");

                entity.Property(e => e.Pnum).HasColumnType("int(11)");

                entity.Property(e => e.Pstate).HasColumnType("varchar(20)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => new { d.Dno, d.Bno })
                    .HasConstraintName("FK_Reference_7");
            });

            modelBuilder.Entity<Repairpaper>(entity =>
            {
                entity.HasKey(e => e.Rno)
                    .HasName("PRIMARY");

                entity.ToTable("repairpaper");

                entity.HasIndex(e => e.Pno)
                    .HasName("FK_Reference_12");

                entity.HasIndex(e => new { e.Dno, e.Bno })
                    .HasName("FK_Reference_8");

                entity.Property(e => e.Rno).HasColumnType("int(11)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Dno).HasColumnType("varchar(20)");

                entity.Property(e => e.Pno).HasColumnType("int(11)");

                entity.Property(e => e.Rreasion).HasColumnType("varchar(20)");

                entity.Property(e => e.Rstate).HasColumnType("varchar(20)");

                entity.HasOne(d => d.PnoNavigation)
                    .WithMany(p => p.Repairpaper)
                    .HasForeignKey(d => d.Pno)
                    .HasConstraintName("FK_Reference_12");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Repairpaper)
                    .HasForeignKey(d => new { d.Dno, d.Bno })
                    .HasConstraintName("FK_Reference_8");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Sno)
                    .HasName("PRIMARY");

                entity.ToTable("student");

                entity.HasIndex(e => new { e.Dno, e.Bno })
                    .HasName("FK_Reference_11");

                entity.Property(e => e.Sno).HasColumnType("varchar(20)");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Dno).HasColumnType("varchar(20)");

                entity.Property(e => e.Smajor).HasColumnType("varchar(100)");

                entity.Property(e => e.Sname).HasColumnType("varchar(20)");

                entity.Property(e => e.Spassword).HasColumnType("varchar(20)");

                entity.Property(e => e.Ssex).HasColumnType("varchar(6)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => new { d.Dno, d.Bno })
                    .HasConstraintName("FK_Reference_11");
            });

            modelBuilder.Entity<Studentbuilding>(entity =>
            {
                entity.HasKey(e => e.Bno)
                    .HasName("PRIMARY");

                entity.ToTable("studentbuilding");

                entity.HasIndex(e => e.Ano)
                    .HasName("FK_Reference_4");

                entity.Property(e => e.Bno).HasColumnType("varchar(20)");

                entity.Property(e => e.Ano).HasColumnType("varchar(20)");

                entity.Property(e => e.Bdnum).HasColumnType("int(11)");

                entity.Property(e => e.Bdsnum).HasColumnType("int(11)");

                entity.Property(e => e.Bsex).HasColumnType("varchar(4)");

                entity.HasOne(d => d.AnoNavigation)
                    .WithMany(p => p.Studentbuilding)
                    .HasForeignKey(d => d.Ano)
                    .HasConstraintName("FK_Reference_4");
            });
        }
    }
}
