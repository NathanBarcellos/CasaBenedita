using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaBeneditaMVC.Controllers
{
    public class ReservaController : Controller
    {
        private readonly AppDbContext _context;

        public ReservaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Criar(int MesaId, string HorarioReserva)
        {
            var dataHoje = DateTime.Today;

            bool mesaOcupada = _context.Reservas.Any(r =>
                r.MesaId == MesaId &&
                r.DataReserva.Date == dataHoje &&
                r.HorarioReserva == HorarioReserva
            );

            if (mesaOcupada)
            {
                TempData["Erro"] = "Essa mesa já está reservada nesse horário. Escolha outra mesa ou outro horário.";
                return RedirectToAction("Reserva", "Home");
            }

            var reserva = new Reserva
            {
                MesaId = MesaId,
                HorarioReserva = HorarioReserva,
                DataReserva = DateTime.Now,
                NomeCliente = "Teste",
                EmailCliente = "teste@email.com",
                TelefoneCliente = "000000000",
                StatusReserva = "Confirmada"
            };

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            TempData["Sucesso"] = "Reserva confirmada com sucesso!";

            return RedirectToAction("Reserva", "Home");
        }
    }
}