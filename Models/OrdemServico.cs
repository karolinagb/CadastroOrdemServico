using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CadastroOrdemServico.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }

        [Display(Name = "Número")]
        public int Numero { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "CNPJ do Cliente")]
        public string CNPJCliente { get; set; }

        [Display(Name = "Nome do Cliente")]
        public string NomeCliente { get; set; }

        [Display(Name = "CPF do Prestador de Serviço")]
        public string CPFPrestadorServico { get; set; }

        [Display(Name = "Nome do Prestador de Serviço")]
        public string NomePrestadorServico { get; set; }
        
        public DateTime Data { get; set; }
        [Display(Name = "Valor")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
    }
}
