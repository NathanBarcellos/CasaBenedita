using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CasaBeneditaMVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }
    }
}