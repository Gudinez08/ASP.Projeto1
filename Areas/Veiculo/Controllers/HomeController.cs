using Microsoft.AspNetCore.Mvc;

namespace Exe.Areas.Veiculo.Controllers
{
    [Area("Veiculo")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
