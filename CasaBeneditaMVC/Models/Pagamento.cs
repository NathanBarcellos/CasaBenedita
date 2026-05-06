using System;

namespace CasaBeneditaMVC.Models
{
    public class Pagamento
    {
        public int PagamentoId { get; set; }

        public string MetodoPagamento { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataPagamento { get; set; }

        public string StatusPagamento { get; set; }

        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }
    }
}