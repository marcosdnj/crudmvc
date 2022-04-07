using Microsoft.AspNetCore.Mvc;

namespace crud.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
