using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CasaBeneditaMVC.Controllers
{
    public class ContaController : Controller
    {
        private readonly AppDbContext _context;

        public ContaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                _context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return BadRequest();
        }
    }
}