using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Projeto.CheckPoint.Models;

namespace Projeto.CheckPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (!File.Exists("usuarios.csv"))
            {
                UsuarioModel usuario = new UsuarioModel();
                usuario.Admin=true;
               
            }
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
