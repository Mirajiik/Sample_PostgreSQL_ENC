using Microsoft.EntityFrameworkCore;

namespace PostgreSQL_ENC.Models.Base
{
    class Context : DbContext
    {
        public Context() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"host=localhost;port=5432;database=university;username=postgres;password=admin");
        }
        public DbSet<Student> Students {get; set;}
        public DbSet<Teacher> Teachers { get; set;}
        public DbSet<Grade> Grades { get; set; }
    }
}
