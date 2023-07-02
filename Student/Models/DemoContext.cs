using Microsoft.EntityFrameworkCore;

namespace Student.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
        }
        public DbSet<Matricula> matriculas { get; set; }
        public DbSet<Estudiante> estudiantes { get; set; }
    }
}
