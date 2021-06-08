using CadastroOrdemServico.Data;
using CadastroOrdemServico.Models;
using CadastroOrdemServico.Repositories.Interfaces;

namespace CadastroOrdemServico.Repositories
{
    public class OrdemServicoRepository : IOrdemServicoRepository
    {
        private readonly CadastroOrdemServicoContext _cadastroOrdemServicoContext;

        public OrdemServicoRepository(CadastroOrdemServicoContext cadastroOrdemServicoContext)
        {
            _cadastroOrdemServicoContext = cadastroOrdemServicoContext;
        }

        public void Insert(OrdemServico ordemServico)
        {
            _cadastroOrdemServicoContext.OrdensServico.Add(ordemServico);
            _cadastroOrdemServicoContext.SaveChanges();
        }
    }
}
