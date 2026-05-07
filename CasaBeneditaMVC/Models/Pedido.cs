using System;
using System.Collections.Generic;

namespace CasaBeneditaMVC.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorTotal { get; set; }
        public string Status { get; set; }

        public string? Rua { get; set; }
        public string? Numero { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? CEP { get; set; }
        public string? Complemento { get; set; }

        public int? UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public List<Pagamento> Pagamentos { get; set; } = new();
        public List<ItemPedido> ItensPedido { get; set; } = new();
    }
}