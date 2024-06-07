using System.ComponentModel.DataAnnotations;

namespace loja.models
{
    public class Fornecedor
    {
        [Key]
        public int? Id { get; set; }

        public string? Cnpj { get; set; }

        public string? Nome { get; set; }

        public string? Endereco { get; set; }

        public double Telefone { get; set; }
    }
}