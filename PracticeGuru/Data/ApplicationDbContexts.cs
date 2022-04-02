using Microsoft.EntityFrameworkCore;
using PracticeGuru.Models;

namespace PracticeGuru.Data
{
    public class ApplicationDbContexts : DbContext
    {
        
        public ApplicationDbContexts(DbContextOptions<ApplicationDbContexts> options) : base(options)
        {
                
        }
        public DbSet<TeacherDb> TeacherInfo { get; set; }

        public DbSet<Student> StudentInfo { get; set; }

        public DbSet<Courses> CourseList { get; set; }
    }
}
