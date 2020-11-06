using System.Data.Entity;
using ProjetoModeloDDD2.domain.Entities;

namespace ProjetoDDD.infraestrutura.Data.Contexto
{
    public class ProjetoModeloContexto : DbContext
    {
        public ProjetoModeloContexto()
        :base("ProjetoDDD")
        {
            
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}