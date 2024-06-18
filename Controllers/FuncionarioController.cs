using Microsoft.AspNetCore.Mvc;

namespace Exe.Controllers
{
	public class FuncionarioController : Controller
	{
		public IActionResult Index()
		{
            ViewData["Title"] = "Funcionário";
            return View();
		}
	}
}
