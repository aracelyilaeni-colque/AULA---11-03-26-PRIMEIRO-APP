using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;

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
        public IActionResult Teste()
        {
            TempData["MSG_EX"] = "Mensagem do TempData";
            return RedirectToAction("Resultado");

        }

        public IActionResult Resultado()
        {

            if (TempData[ "MSG_EX"] != null)
            ViewBag.Exemplo = "Aluno ETEC MB";
            return View();

        }
    }
}
