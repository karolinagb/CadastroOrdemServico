using CadastroOrdemServico.Models;
using System.Collections.Generic;

namespace CadastroOrdemServico.Repositories.Interfaces
{
    public interface IOrdemServicoRepository
    {
        public void Insert(OrdemServico ordemServico);
        public int BeUnique(int numeroOrdemServico);
        public List<OrdemServico> FindAll();
    }
}
