using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace CasaBeneditaMVC.Controllers
{
    public class ReservaController : Controller
    {
        private readonly AppDbContext _context;

        public ReservaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sucesso()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(
            DateTime DataReserva,
            string HorarioReserva,
            string NomeCliente,
            string EmailCliente,
            string TelefoneCliente)
        {
            if (string.IsNullOrEmpty(HorarioReserva) || DataReserva == default)
            {
                TempData["Erro"] = "Escolha uma data e um horário.";
                return RedirectToAction("Index");
            }

            var horarioSelecionado = TimeSpan.Parse(HorarioReserva);

            var reservasDoDia = _context.Reservas
                .Where(r => r.DataReserva.Date == DataReserva.Date)
                .ToList();

            bool horarioOcupado = reservasDoDia.Any(r =>
                Math.Abs((TimeSpan.Parse(r.HorarioReserva) - horarioSelecionado).TotalMinutes) < 60
            );

            if (horarioOcupado)
            {
                TempData["Erro"] = "Já existe uma reserva em um horário próximo.";
                return RedirectToAction("Index");
            }

            var reserva = new Reserva
            {
                MesaId = null,
                DataReserva = DataReserva,
                HorarioReserva = HorarioReserva,
                NomeCliente = NomeCliente,
                EmailCliente = EmailCliente,
                TelefoneCliente = TelefoneCliente,
                StatusReserva = "Confirmada"
            };

            _context.Reservas.Add(reserva);
            _context.SaveChanges();

            return RedirectToAction("Sucesso");
        }
    }
}