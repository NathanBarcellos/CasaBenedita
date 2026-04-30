using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private bool EhAdmin()
        {
            return HttpContext.Session.GetString("EhAdmin") == "True";
        }

        public IActionResult Index()
        {
            if (!EhAdmin())
                return RedirectToAction("Index", "Home");

            var produtos = _context.Produtos
                .Include(p => p.Categoria)
                .ToList();

            return View(produtos);
        }

        public IActionResult Create()
        {
            if (!EhAdmin())
                return RedirectToAction("Index", "Home");

            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            if (!EhAdmin())
                return RedirectToAction("Index", "Home");

            if (ModelState.IsValid)
            {
                _context.Produtos.Add(produto);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        public IActionResult Delete(int id)
        {
            if (!EhAdmin())
                return RedirectToAction("Index", "Home");

            var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}