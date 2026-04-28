using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CasaBeneditaMVC.Controllers
{
    public class CardapioController : Controller
    {
        private readonly AppDbContext _context;

        public CardapioController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos
                .Include(p => p.Categoria)
                .ToList();

            return View(produtos);
        }
    }
}