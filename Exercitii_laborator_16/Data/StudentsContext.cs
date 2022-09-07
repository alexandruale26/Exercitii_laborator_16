using Exercitii_laborator_16.Models;
using Microsoft.EntityFrameworkCore;

namespace Exercitii_laborator_16.Data
{
    public class StudentsContextDB : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Alexandru\\source\\repos\\Exercitii_laborator_16\\Exercitii_laborator_16\\StudentsDb.mdf;Integrated Security=True");
        }
    }
}
