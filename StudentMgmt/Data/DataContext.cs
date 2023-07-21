using Microsoft.EntityFrameworkCore;
using StudentMgmt.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace StudentMgmt.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> Enrollments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("tblStudent");
            modelBuilder.Entity<Course>().ToTable("tblCourse");
            modelBuilder.Entity<StudentCourse>().ToTable("tblEnrollments");
        }
    }
}
