using Microsoft.AspNetCore.Mvc;

namespace CasaBeneditaMVC.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }
    }
}