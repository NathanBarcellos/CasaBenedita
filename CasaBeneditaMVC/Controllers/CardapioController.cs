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

        public IActionResult Index(string pesquisa)
        {
            var produtos = _context.Produtos
                .Include(p => p.Categoria)
                .AsQueryable();

            if (!string.IsNullOrEmpty(pesquisa))
            {
                produtos = produtos.Where(p =>
                    p.Nome.Contains(pesquisa));
            }

            return View(produtos.ToList());
        }
    }
}