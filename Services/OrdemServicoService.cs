using CadastroOrdemServico.Repositories.Interfaces;

namespace CadastroOrdemServico.Services
{
    public class OrdemServicoService
    {
        private readonly IOrdemServicoRepository _ordemServicoRepository;

        public OrdemServicoService(IOrdemServicoRepository ordemServicoRepository)
        {
            _ordemServicoRepository = ordemServicoRepository;
        }

        public int BeUnique(int numeroOrdemServico)
        {
            return _ordemServicoRepository.BeUnique(numeroOrdemServico);
        }
    }
}
