using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CasaBeneditaMVC.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(50)]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}