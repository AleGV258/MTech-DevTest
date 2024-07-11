using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DevCandidateTest_MichellAlejandroGarciaVargas.Models;

public partial class DataStoreDbContext : DbContext
{
    public DataStoreDbContext()
    {
    }

    public DataStoreDbContext(DbContextOptions<DataStoreDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    // Sutitución de la ruta absoluta por la ruta de la BD en la máquina a provar.
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\alegv\\source\\repos\\DevCandidateTest-MichellAlejandroGarciaVargas\\DevCandidateTest-MichellAlejandroGarciaVargas\\Database\\DataStoreDB.mdf; Database=DataStoreDB; Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.IdEmployee).HasName("PK__Employee__D9EE4F36F461663C");

            entity.ToTable("Employee");

            //entity.HasIndex(e => e.RfcEmployee, "UQ__Employee__14477C4584DD991A").IsUnique();

            entity.Property(e => e.IdEmployee).HasColumnName("ID_Employee");
            entity.Property(e => e.BornDateEmployee).HasColumnName("BornDate_Employee");
            entity.Property(e => e.LastNameEmployee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LastName_Employee");
            entity.Property(e => e.NameEmployee)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Name_Employee");
            entity.Property(e => e.RfcEmployee)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("RFC_Employee");
            entity.Property(e => e.StatusEmployee)
                .HasConversion<string>()
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValue(EmployeeStatus.NotSet)
                .HasColumnName("Status_Employee");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
