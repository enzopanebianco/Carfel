using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.CheckPoint.Models;
using Projeto.CheckPoint.Repositorio;

namespace Projeto.CheckPoint.Controllers {
    public class ComentarioController : Controller {
        [HttpGet]
        public IActionResult Comentar () {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
            ComentarioModel comentarioModel = new ComentarioModel ();
             ViewData["ComentariosAprovados"]=comentarioRepositorio.Listar().Where(comentario => comentario.Tipo == "Aprovado").ToList();

                     return View ();

        }

        [HttpPost]
        public IActionResult Comentar (IFormCollection form) {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
            UsuarioModel usuario = new UsuarioModel ();

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            ComentarioModel comentarioModel = new ComentarioModel ();
            if (System.IO.File.Exists ("comentarios.csv")) {
                comentarioModel.IdComentario = System.IO.File.ReadAllLines ("comentarios.csv").Length + 1;
            } else {
                comentarioModel.IdComentario = 1;
            }
            if (comentarioModel.Nome==null)
            {
                comentarioModel.Nome="Usuario Desconhecido";
            }
            comentarioModel.Nome = HttpContext.Session.GetString ("NomeDoUsuario");
            comentarioModel.Comentario = form["comentario"];
            comentarioModel.dataComentario = DateTime.Now;
            comentarioModel.Tipo = "EmEspera";

            using (StreamWriter sw = new StreamWriter ("comentarios.csv", true)) {
                sw.WriteLine ($"{comentarioModel.IdComentario};{comentarioModel.Nome};{comentarioModel.Comentario};{comentarioModel.dataComentario};{comentarioModel.Tipo}");
            }
            ViewBag.Mensagem = "Comentário Enviado";

            return RedirectToAction ("Comentar");
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            ComentarioRepositorio rep = new ComentarioRepositorio ();
            rep.Excluir (id);
            TempData["Mensagem"] = "Comentário Excluído";
            return RedirectToAction ("Administrar", "Administrador");

        }

        [HttpGet]
        public IActionResult ListarAprovados (int id) {
            if (id == 0) {
                TempData["Mensagem"] = "Informe seu Id";
                return RedirectToAction ("Administrar,Administrador");
            }

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio ();
            ComentarioModel comentario = comentarioRepositorio.GuardarComentarioAprovados(id);
            if (comentario != null)
            {
                ViewBag.Comentario = comentario;
                return View();
            }
            TempData["Mensagem"] = "Usuário não encontrado";
            return RedirectToAction ("Aministrar,Administrador");
        }
            
            
        
        [HttpPost]
        public IActionResult Alterar (IFormCollection form) {
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Alterar(int.Parse(form["id"]), form["tipo"]);

            return RedirectToAction ("Administrar", "Administrador");
        }

    }
}