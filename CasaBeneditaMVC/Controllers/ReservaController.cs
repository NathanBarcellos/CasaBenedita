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

        // 👉 ESSA PARTE FALTAVA
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(
            int MesaId,
            string HorarioReserva,
            string NomeCliente,
            string EmailCliente,
            string TelefoneCliente)
        {
            var dataHoje = DateTime.Today;

            var horarioSelecionado = TimeSpan.Parse(HorarioReserva);

            var reservasDoDia = _context.Reservas
                .Where(r => r.MesaId == MesaId && r.DataReserva.Date == dataHoje)
                .ToList();

            bool mesaOcupada = reservasDoDia.Any(r =>
                Math.Abs((TimeSpan.Parse(r.HorarioReserva) - horarioSelecionado).TotalMinutes) < 60
            );

            if (mesaOcupada)
            {
                TempData["Erro"] = "Essa mesa já está reservada em um horário próximo.";
                return RedirectToAction("Index");
            }

            var reserva = new Reserva
            {
                MesaId = MesaId,
                HorarioReserva = HorarioReserva,
                DataReserva = DateTime.Now,
                NomeCliente = NomeCliente,
                EmailCliente = EmailCliente,
                TelefoneCliente = TelefoneCliente,
                StatusReserva = "Confirmada"
            };

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            TempData["Sucesso"] = "Reserva confirmada com sucesso!";

            return RedirectToAction("Index");
        }
    }
}