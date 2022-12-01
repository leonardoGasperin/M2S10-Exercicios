using M2S10API.Models;
using Microsoft.EntityFrameworkCore;

namespace M2S10API.Context
{
    public class M2S10Context : DbContext
    {
        public M2S10Context(DbContextOptions<M2S10Context> opt) : base(opt) 
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}
