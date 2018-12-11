using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.CheckPoint.Models;
using Projeto.CheckPoint.Repositorio;

namespace Projeto.CheckPoint.Controllers
{
    public class AdministradorController:Controller
    {
        [HttpGet]
        public IActionResult  Administrar(){ 
            ComentarioRepositorio  rep = new  ComentarioRepositorio();
            ViewData["Comentarios"] =  rep.Listar().Where(comentario => comentario.Tipo == "EmEspera").ToList();
            return View();
        }
    
    }
}