using System;

namespace CadastroOrdemServico.Models
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Titulo { get; set; }
        public string CNPJCliente { get; set; }
        public string NomeCliente { get; set; }
        public string CPFPrestadorServico { get; set; }
        public string NomePrestadorServico { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }
}
