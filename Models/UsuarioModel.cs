using System;

namespace Projeto.CheckPoint.Models
{
    public class UsuarioModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        public int ID { get; set; }
        public bool Admin { get; set; }
    }
}