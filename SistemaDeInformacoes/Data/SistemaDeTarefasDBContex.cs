using Microsoft.EntityFrameworkCore;
using SistemaDeInformacoes.Data.Map;
using SistemaDeInformacoes.Models;

namespace SistemaDeInformacoes.Data
{
    public class SistemaDeTarefasDBContex:DbContext
    {
        public SistemaDeTarefasDBContex(DbContextOptions<SistemaDeTarefasDBContex>options):base(options)
        {

        }

        public DbSet<UsuarioModel>Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
         
    }
}
