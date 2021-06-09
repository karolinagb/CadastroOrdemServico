using CadastroOrdemServico.Data;
using CadastroOrdemServico.Models;
using CadastroOrdemServico.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

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

        public int BeUnique(int numeroOrdemServico)
        {
            return _cadastroOrdemServicoContext.OrdensServico.Where(x => x.Numero == numeroOrdemServico).Count();
        }

        public List<OrdemServico> FindAll()
        {
            return _cadastroOrdemServicoContext.OrdensServico.ToList();
        }

        public OrdemServico GetById(int id)
        {
            return _cadastroOrdemServicoContext.OrdensServico.FirstOrDefault(x => x.Id == id);
        }

        public void Update(OrdemServico ordemServico)
        {
            _cadastroOrdemServicoContext.OrdensServico.Update(ordemServico);
            _cadastroOrdemServicoContext.SaveChanges();
        }
    }
}
