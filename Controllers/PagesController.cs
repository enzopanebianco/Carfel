using Microsoft.AspNetCore.Mvc;

namespace Projeto.CheckPoint.Controllers
{
    public class PagesController:Controller
    {
  
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        [HttpGet]
        public IActionResult Sac(){
            return View();
        }
        [HttpGet]
        public IActionResult Faq(){
            return View();
        }
        [HttpGet]
        public IActionResult Sobre(){
            return View();
        }
    }
}
    