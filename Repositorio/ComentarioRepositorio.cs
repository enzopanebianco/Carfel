using System;
using System.Collections.Generic;
using System.IO;
using Projeto.CheckPoint.Models;

namespace Projeto.CheckPoint.Repositorio {
    public class ComentarioRepositorio {
            public List<ComentarioModel> GuardarComentario () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();
            string[] linhas = File.ReadAllLines ("comentarios.csv");
            foreach (string item in linhas) {
                if (string.IsNullOrEmpty (item)) {
                    continue;
                }

                string[] dados = item.Split (";");
                ComentarioModel comentario = new ComentarioModel ();
                comentario.IdComentario = int.Parse (dados[0]);
                comentario.Nome = dados[1];
                comentario.Comentario = dados[2];
                comentario.dataComentario = DateTime.Parse (dados[3]);
                comentario.Tipo = dados[4];

                lsComentarios.Add (comentario);
            }
            return lsComentarios;
        }
        public ComentarioModel GuardarComentarioAprovados (int id) {
           string[] linhas = System.IO.File.ReadAllLines ("comentarios.csv");
            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }
                string[] dados = linhas[i].Split (";");
                if (dados[0] == id.ToString ()) {
                    ComentarioModel comentario = new ComentarioModel {
                    IdComentario = int.Parse (dados[0]),
                    Nome = dados[1],
                    Comentario = dados[2],
                    dataComentario = DateTime.Parse(dados[3]),
                    Tipo =  dados[4]

                    };
                    return comentario;
                }
            }
            return null;
        }
        public List<ComentarioModel> Listar () => GuardarComentario ();
        
       
        
         public List<ComentarioModel> ListarAprovados (ComentarioModel comentario) 
         {
          List<ComentarioModel> lsComentarios = new List<ComentarioModel>();
            string[] linhas = System.IO.File.ReadAllLines ("comentarios.csv");
            for (int i = 0; i < linhas.Length; i++) {
                if (string.IsNullOrEmpty (linhas[i])) {
                    continue;
                }
                string[] dados = linhas[i].Split (";");
               
                if (dados[0] == comentario.IdComentario.ToString ()) {
                    linhas[i] = $"{comentario.IdComentario};{comentario.Nome};{comentario.Comentario};{comentario.dataComentario};{comentario.Tipo}";
                    break;
                }
            }
            System.IO.File.WriteAllLines ("comentarios.csv", linhas);
            return lsComentarios;
        }

        public void Excluir (int id) {

            string[] linhas = File.ReadAllLines ("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++) {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split (';');
                if (id.ToString () == dadosDaLinha[0]) {
                    linhas[i] = "";
                    break;
                }
            }
            File.WriteAllLines ("comentarios.csv", linhas);
        }

        public void Alterar (int id, string tipo) {

            string[] linhas = File.ReadAllLines ("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++) {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split (';');
                if (id.ToString () == dadosDaLinha[0]) {
                    linhas[i] = $"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};{tipo}";
                    break;
                }
            }
            File.WriteAllLines ("comentarios.csv", linhas);
        }
    }
}