using ApiAula.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiAula.Data
{
    public class ContextDB : DbContext
    {
        public ContextDB(DbContextOptions<ContextDB> options) : base(options) { }

        public DbSet<Professor> Professor { get; set; }
        public DbSet<Disciplina> Disciplina { get; set; }
        public DbSet<Curso> Curso { get; set; }
    }
}
