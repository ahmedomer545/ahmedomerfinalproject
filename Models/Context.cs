using Microsoft.EntityFrameworkCore;

namespace ahmedomerfinalproject.Models
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>().HasKey(s => new {s.CourseID, s.StudentID});
        }

        public DbSet<Course> Course {get; set;}

        public DbSet<Student> Student {get; set;}


        public DbSet<StudentCourse> StudentCourse {get; set;}
    }
}