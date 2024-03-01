using Microsoft.AspNetCore.Mvc;
using rm551575.Models;

namespace rm551575.Controllers
{
    public class AlunosController : Controller
    {
        public IActionResult Index()
        {
            Aluno andre = new Aluno("André", "rm551575@fiap.com.br", 551575);
            return View();
        }
    }
}
