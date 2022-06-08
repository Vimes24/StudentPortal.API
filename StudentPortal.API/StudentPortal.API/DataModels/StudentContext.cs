using Microsoft.EntityFrameworkCore;

namespace StudentPortal.API.DataModels
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
