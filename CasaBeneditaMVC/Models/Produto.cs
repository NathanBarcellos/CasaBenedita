using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CasaBeneditaMVC.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "Digite o nome do produto")]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Digite o preço")]
        [Range(0.01, 9999, ErrorMessage = "Preço inválido")]
        public decimal Preco { get; set; }

        public string? ImagemUrl { get; set; }

        public bool Disponivel { get; set; } = true;

        [Required(ErrorMessage = "Selecione a categoria")]
        public int CategoriaId { get; set; }

        public Categoria? Categoria { get; set; }
        public List<ItemPedido>? ItensPedido { get; set; }
    }
}