using System;
using System.Collections.Generic;
using System.IO;
using Projeto.CheckPoint.Models;

namespace Projeto.CheckPoint.Repositorio
{
    public class UsuarioRepositorio
    {
        public UsuarioModel Cadastrar(UsuarioModel usuario){
            if (File.Exists("usuarios.csv"))
            {
                usuario.ID = File.ReadAllLines("usuarios.csv").Length +1;
            }
            else
            {
                usuario.ID=1;
            }
             if (!File.Exists("usuarios.csv"))
            {
                
                usuario.Admin=true;
               
            }
        
            using (StreamWriter sw = new StreamWriter("usuarios.csv",true))
            {

                sw.WriteLine($"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataCriacao};{usuario.Admin}");
            }
            return usuario;
        }
        public UsuarioModel ValidarCadastro(string email, string senha,string nome,int ID,bool Admin){
            List<UsuarioModel> lsUsuarios = LerArquivo();
            foreach (UsuarioModel usuario  in lsUsuarios)
            {  
            if (usuario.Email == email && usuario.Senha == senha )
            {
              return usuario;
            }
            }
                return null;
        }
        public List<UsuarioModel> LerArquivo(){
            List<UsuarioModel> lsUsuarios  = new List<UsuarioModel>();
            string[] linhas = File.ReadAllLines("usuarios.csv");
            foreach (string item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                UsuarioModel usuario = new UsuarioModel();
                usuario.ID = int.Parse(dados[0]);
                usuario.Nome = dados[1];
                usuario.Email = dados[2];
                usuario.Senha = dados[3];
                usuario.DataCriacao = DateTime.Parse(dados[4]);
                usuario.Admin = Boolean.Parse(dados[5]);
               
                lsUsuarios.Add(usuario);
            }
            return lsUsuarios;
        }
        
        public UsuarioModel VerificarAdministrador(){
           
             List<UsuarioModel> lsUsuarios = new List<UsuarioModel>();
             lsUsuarios = LerArquivo();
             foreach (UsuarioModel usuario  in LerArquivo())
             {
                 if (usuario.ID==1)
                 {
                     usuario.Admin=true;
                     return usuario;
                 }
                 else
                 {
                     usuario.Admin=false;
                 }
             }
             return null;
        }
        
    }
}