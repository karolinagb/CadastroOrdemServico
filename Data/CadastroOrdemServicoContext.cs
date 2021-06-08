using CadastroOrdemServico.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroOrdemServico.Data
{
    public class CadastroOrdemServicoContext : DbContext
    {
        public CadastroOrdemServicoContext(DbContextOptions<CadastroOrdemServicoContext> options) : base(options)
        {
        }

        public DbSet<OrdemServico> OrdensServico { get; set; }
    }
}
