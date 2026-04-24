using System.Collections.Generic;

namespace CasaBeneditaMVC.Models
{
    public class Mesa
    {
        public int MesaId { get; set; }
        public int NumeroMesa { get; set; }
        public int Capacidade { get; set; }
        public bool Disponivel { get; set; }

        public List<Reserva> Reservas { get; set; } = new List<Reserva>();
    }
}