using CadastroOrdemServico.Models;

namespace CadastroOrdemServico.Repositories.Interfaces
{
    public interface IOrdemServicoRepository
    {
        public void Insert(OrdemServico ordemServico);
        public int BeUnique(int numeroOrdemServico);
    }
}
