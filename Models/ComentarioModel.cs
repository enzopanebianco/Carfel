using System;

namespace Projeto.CheckPoint.Models
{
    public class ComentarioModel
    {
        public int IdComentario { get; set; }
        public string Nome {get;set;} 
        public string Comentario { get; set; }
        public DateTime dataComentario { get; set; }
        public string Tipo {get;set;}
    }
}