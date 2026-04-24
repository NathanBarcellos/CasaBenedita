using System.ComponentModel.DataAnnotations;

namespace CasaBeneditaMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public bool Disponivel { get; set; } = true;

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}