using CadastroOrdemServico.Services;
using FluentValidation;
using System;
using System.Text.RegularExpressions;

namespace CadastroOrdemServico.Models.ViewModelValidators
{
    public class OrdemServicoViewModelValidator : AbstractValidator<OrdemServico>
    {
        private readonly OrdemServicoService _ordemServicoService;

        public OrdemServicoViewModelValidator(OrdemServicoService ordemServicoService)
        {
            _ordemServicoService = ordemServicoService;

            RuleFor(x => x.Numero).Must(BeUnique).WithMessage("Ordem de serviço já existe")
                .NotEmpty().WithMessage("Digite o número da Ordem de Serviço");
            RuleFor(x => x.Titulo).NotEmpty().WithName("teste").WithMessage("Digite o Título da Ordem de Serviço");
            RuleFor(x => x.CNPJCliente).NotEmpty().WithMessage("Digite o CNPJ do cliente")
                .IsValidCNPJ().WithMessage("CNPJ inválido");
            RuleFor(x => x.CPFPrestadorServico).NotEmpty().WithMessage("Digite o CPF do prestador de serviço")
                .IsValidCPF().WithMessage("CPF inválido");
            RuleFor(x => x.NomeCliente).NotEmpty().WithMessage("Digite o nome do cliente");
            RuleFor(x => x.Data).NotEmpty().WithMessage("Digite a data do serviço")
                .Must(ValidDate).WithMessage("Data não pode ser posterior a hoje");
            RuleFor(x => x.Valor).NotEmpty().WithMessage("Digite o valor do serviço");
        }

        public bool BeUnique(OrdemServico ordemservico, int numero)
        {
            var count = _ordemServicoService.BeUnique(numero, ordemservico.Id);

            if(count == 0)
            {
                return true;
            }

            return false;
        }

        public bool ValidDate(DateTime date)
        {
            if(date.Date <= DateTime.Now)
            {
                return true;
            }
            return false;
        }
    }
}
