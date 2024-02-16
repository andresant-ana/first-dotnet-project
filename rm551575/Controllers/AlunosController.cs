using Microsoft.AspNetCore.Mvc;

namespace rm551575.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
