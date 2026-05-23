using Microsoft.AspNetCore.Mvc;

namespace minhapaginaweb.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nome = "Luan"; 
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";
            return View("Index");
        }

        public IActionResult Detalhes(int id)
        {
            ViewBag.Id = id;
            ViewBag.Nome = "Luan"; 
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "3º Semestre";

            return View("Detalhes");
        }
    }
}
