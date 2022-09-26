using TestGardenUniversity.Models;
using Microsoft.EntityFrameworkCore;
namespace TestGardenUniversity.Data
{
    public class GardenSchoolContext : DbContext
    {
        public GardenSchoolContext(DbContextOptions<GardenSchoolContext> options) : base(options)
        { 
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Student { get; set; }

        //override in this tutorial to manually rename table property names, not necessary as EF uses Collection names
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
