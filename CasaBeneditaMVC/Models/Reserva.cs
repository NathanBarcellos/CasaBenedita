using System;

namespace CasaBeneditaMVC.Models
{
    public class Reserva
    {
        public int ReservaId { get; set; }

        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string TelefoneCliente { get; set; }

        public DateTime DataReserva { get; set; }
        public string HorarioReserva { get; set; }

        public int MesaId { get; set; }
        public Mesa Mesa { get; set; }

        public string StatusReserva { get; set; }

        public int? UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}