using CadastroOrdemServico.Models;
using System.Collections.Generic;

namespace CadastroOrdemServico.Repositories.Interfaces
{
    public interface IOrdemServicoRepository
    {
        public void Insert(OrdemServico ordemServico);
        public int BeUnique(int numeroOrdemServico, int? id);
        public List<OrdemServico> FindAll();
        public OrdemServico GetById(int id);
        public void Update(OrdemServico ordemServico);
        public void Remove(int id);
    }
}
