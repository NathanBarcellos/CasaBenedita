using CasaBeneditaMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CasaBeneditaMVC.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.EhAdmin = false; 

                _context.Usuarios.Add(usuario);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Home");
        }

       
        [HttpPost]
        public IActionResult Login(string email, string senha)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuario == null)
            {
                TempData["ErroLogin"] = "Email ou senha inválidos";
                return RedirectToAction("Index", "Home");
            }

            HttpContext.Session.SetString("UsuarioLogado", usuario.Nome);
            HttpContext.Session.SetString("EhAdmin", usuario.EhAdmin.ToString());

            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult CriarAdmin()
        {
            var adminExiste = _context.Usuarios
                .Any(u => u.Email == "admin@admin.com");

            if (!adminExiste)
            {
                var admin = new Usuario
                {
                    Nome = "Admin",
                    Email = "admin@admin.com",
                    Senha = "123",
                    EhAdmin = true
                };

                _context.Usuarios.Add(admin);
                _context.SaveChanges();
            }

            return Content("Admin criado! Email: admin@admin.com | Senha: 123");
        }
    }
}