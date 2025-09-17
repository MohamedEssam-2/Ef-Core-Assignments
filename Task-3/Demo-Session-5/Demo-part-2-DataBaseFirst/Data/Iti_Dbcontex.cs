using System;
using System.Collections.Generic;
using Demo_part_2_DataBaseFirst.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_part_2_DataBaseFirst.Data;

public partial class Iti_Dbcontex : DbContext
{
    public Iti_Dbcontex()
    {
    }

    public Iti_Dbcontex(DbContextOptions<Iti_Dbcontex> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseInst> CourseInsts { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<StuDepVeiw> StuDepVeiws { get; set; }

    public virtual DbSet<StudCourse> StudCourses { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-1JO19MD; Database=CompanyTest-2; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasIndex(e => e.TopId, "IX_Courses_Top_id");

            entity.Property(e => e.TopId).HasColumnName("Top_id");

            entity.HasOne(d => d.Top).WithMany(p => p.Courses).HasForeignKey(d => d.TopId);
        });

        modelBuilder.Entity<CourseInst>(entity =>
        {
            entity.HasKey(e => new { e.InstId, e.CourseId });

            entity.ToTable("Course_Insts");

            entity.HasIndex(e => e.CourseId, "IX_Course_Insts_Course_Id");

            entity.Property(e => e.InstId).HasColumnName("Inst_Id");
            entity.Property(e => e.CourseId).HasColumnName("Course_Id");
            entity.Property(e => e.Evaluate).HasColumnName("evaluate");

            entity.HasOne(d => d.Course).WithMany(p => p.CourseInsts)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("CourseId");

            entity.HasOne(d => d.Inst).WithMany(p => p.CourseInsts)
                .HasForeignKey(d => d.InstId)
                .HasConstraintName("Inst_id");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasIndex(e => e.InsId, "IX_Departments_Ins_Id")
                .IsUnique()
                .HasFilter("([Ins_Id] IS NOT NULL)");

            entity.Property(e => e.InsId).HasColumnName("Ins_Id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Ins).WithOne(p => p.Department).HasForeignKey<Department>(d => d.InsId);
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasIndex(e => e.DepId, "IX_Instructors_Dep_id");

            entity.Property(e => e.DepId).HasColumnName("Dep_id");

            entity.HasOne(d => d.Dep).WithMany(p => p.Instructors).HasForeignKey(d => d.DepId);
        });

        modelBuilder.Entity<StuDepVeiw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Stu_Dep_Veiw");

            entity.Property(e => e.DepId).HasColumnName("Dep_Id");
            entity.Property(e => e.DepName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dep_Name");
            entity.Property(e => e.StudentName).HasColumnName("Student_Name");
        });

        modelBuilder.Entity<StudCourse>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.CourseId });

            entity.HasIndex(e => e.CourseId, "IX_StudCourses_CourseId");

            entity.HasOne(d => d.Course).WithMany(p => p.StudCourses)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("Course_id");

            entity.HasOne(d => d.Student).WithMany(p => p.StudCourses)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("Student_id");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.DepId, "IX_Students_Dep_id");

            entity.Property(e => e.DepId).HasColumnName("Dep_id");
            entity.Property(e => e.Fname).HasColumnName("FName");
            entity.Property(e => e.Lname).HasColumnName("LName");

            entity.HasOne(d => d.Dep).WithMany(p => p.Students).HasForeignKey(d => d.DepId);
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.ToTable("Topic");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
