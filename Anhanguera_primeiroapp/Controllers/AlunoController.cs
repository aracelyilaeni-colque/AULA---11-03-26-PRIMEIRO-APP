using Microsoft.AspNetCore.Mvc;

namespace Anhanguera_primeiroapp.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.nota = "Aluno Nota 10";
            ViewData["escola"] = "e.e anhanguera";
            return View();
        }
    }
}
