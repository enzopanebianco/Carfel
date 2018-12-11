using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.CheckPoint.Models;
using Projeto.CheckPoint.Repositorio;

namespace Projeto.CheckPoint.Controllers
{
    public class UsuarioController:Controller
    {
        [HttpGet]
        public IActionResult Cadastrar(){
            UsuarioModel usuarioModel = new UsuarioModel();
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
           UsuarioModel usuarioRetornado = usuarioRepositorio.ValidarCadastro(usuarioModel.Email,usuarioModel.Senha,usuarioModel.Nome,usuarioModel.ID,usuarioModel.Admin);
        
            ViewData["Usuario"]=usuarioRetornado;
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form){
            UsuarioModel usuarioModel = new UsuarioModel();
            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];
            usuarioModel.DataCriacao =DateTime.Now;
            usuarioModel.Admin = false;

            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            usuarioRepositorio.Cadastrar(usuarioModel);
            ViewBag.Mensagem = "Usuario Cadastrado";

            return RedirectToAction("Logar");
        }
        [HttpGet]
        public IActionResult Logar()=> View();
        [HttpPost]
        public IActionResult Logar(IFormCollection form){
            UsuarioModel usuarioModel = new UsuarioModel();
            
                usuarioModel.Email = form["email"];
                usuarioModel.Senha = form["senha"];
            
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
           UsuarioModel usuarioRetornado = usuarioRepositorio.ValidarCadastro(usuarioModel.Email,usuarioModel.Senha,usuarioModel.Nome,usuarioModel.ID,usuarioModel.Admin);
            if (usuarioRetornado != null)
            {
                ViewBag.Mensagem="Login Realizado";
                HttpContext.Session.SetString("NomeDoUsuario",usuarioRetornado.Nome.ToString());
                HttpContext.Session.SetString("IDdoUsuario",usuarioRetornado.ID.ToString());
                HttpContext.Session.SetString("TipoUsuario", usuarioRetornado.Admin.ToString());

                if(!usuarioRetornado.Admin )
                    return RedirectToAction ("Index","Pages");
                else
                    return RedirectToAction ("Index","Pages");
            }
            else 
            {   
                ViewBag.Mensagem="Acesso Negado";
            }
          
            return View();
        }
        [HttpGet]
      public IActionResult Verificação(){
            UsuarioModel usuario = new UsuarioModel();
            usuario.Admin=bool.Parse(HttpContext.Session.GetString("TipoUsuario"));

          if (usuario.Admin==true)
          {
              return RedirectToAction("Administrar","Administrador");
          }
          else
          {
              TempData["Mensagem"] = "Você não é um Administraador";
              return RedirectToAction("Index","Pages");
          }
      
           
      }
    }
}