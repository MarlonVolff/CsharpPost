using System.ComponentModel.DataAnnotations;

namespace loja.models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Preco { get; set; }

    }
}