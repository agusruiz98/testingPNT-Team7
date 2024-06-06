using Microsoft.EntityFrameworkCore;
using TPFinal_team_7.Models;

namespace TPFinal_team_7.Context
{
    public class EscuelaDatabaseContext : DbContext
    {
        public EscuelaDatabaseContext(DbContextOptions<EscuelaDatabaseContext> options) : base(options)
        {

        }
        public DbSet<Estudiante> Estudiantes { get; set; }
    }
}