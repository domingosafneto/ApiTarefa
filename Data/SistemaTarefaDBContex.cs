using ApiTarefas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTarefas.Data
{
    public class SistemaTarefaDBContex : DbContext
    {
        public SistemaTarefaDBContex(DbContextOptions<SistemaTarefaDBContex> options) : base(options) 
        { 
                
        }

        public DbSet<UsuarioModel> Usuarios { get; set; } // tabela de usuários a ser criada no migrations

        public DbSet<TarefaModel> Tarefas { get; set; }  // ... de tarefas

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
