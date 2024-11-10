using Microsoft.EntityFrameworkCore;

namespace WebApplication19.Models
{
    public class classContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SM90N3F;Initial Catalog=ModelMvc;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

        }
        public virtual DbSet<student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
    }
}
