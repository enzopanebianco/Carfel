#pragma checksum "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "059e2c662620f294977df768a93ebe86ebec0475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Administrar), @"mvc.1.0.view", @"/Views/Administrador/Administrar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Administrar.cshtml", typeof(AspNetCore.Views_Administrador_Administrar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
using Projeto.CheckPoint.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"059e2c662620f294977df768a93ebe86ebec0475", @"/Views/Administrador/Administrar.cshtml")]
    public class Views_Administrador_Administrar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(60, 334, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb309b341bf1421e95cd34e426634efc", async() => {
                BeginContext(66, 321, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Page Title</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""/css/admin.css"" />
    <script src=""/JS/main.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(394, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(396, 2045, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "727cac2b0b394d9985d5e375918982a8", async() => {
                BeginContext(402, 1292, true);
                WriteLiteral(@"
    
    <section class=""teto"">
        <div class=""carfel"">
        <img src=""/imagem/Ativo 3.png"">
        </div>
        <label >
            <div id=""botao"">
            <i class=""fas fa-bars""  onclick=""mostrar(menu)""></i>
           </div>
            
                         <button class=""index"" ><a href=""/Pages/Index"">Index</a></button>
             
            
        </label>
            <div id=""menu"" class=""fechar"">
                 <i class=""fas fa-times"" onclick=""desligar(menu)"" id=""outroButao""></i>
                 <ul>
          
            <li>
   
                <a href=""#"">HOME</a>
            </li>
            <li>
                <a href=""#"">SAC</a>
            </li>
            <li>
                <a href=""#"">FAQ</a>
            </li>
            <li>
                <a href=""#"">SOBRE NÓS</a>
            </li>

        </ul>
             <div class=""logo"" style=""animation-name: img"">
               <img src=""/imagem/r0j6UUS - Imgur.png"" alt=""Logo");
                WriteLiteral(@" do Produto""> 
            </div>
            </div>
    </section>
    
   <section class=""corpo"">
    <h1>Página Administrador</h1>
    <hr>    
    <img src=""/imagem/Ativo 4.png"">
    <h2>Comentários</h2>
     <table class=""comentarios"">
      
      
");
                EndContext();
#line 60 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
         foreach(ComentarioModel c in ViewData["Comentarios"] as List<ComentarioModel>){

#line default
#line hidden
                BeginContext(1784, 75, true);
                WriteLiteral("        <tr class=\"caixa\">\r\n            <td class=\"nome\">\r\n                ");
                EndContext();
                BeginContext(1860, 6, false);
#line 63 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
           Write(c.Nome);

#line default
#line hidden
                EndContext();
                BeginContext(1866, 83, true);
                WriteLiteral("\r\n            </td>\r\n            \r\n            <td class=\"comen\">\r\n                ");
                EndContext();
                BeginContext(1950, 12, false);
#line 67 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
           Write(c.Comentario);

#line default
#line hidden
                EndContext();
                BeginContext(1962, 68, true);
                WriteLiteral("\r\n            </td>\r\n            <td class=\"data\">\r\n                ");
                EndContext();
                BeginContext(2031, 36, false);
#line 70 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
           Write(c.dataComentario.ToShortDateString());

#line default
#line hidden
                EndContext();
                BeginContext(2067, 83, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n               <button class=\"Rejeitar\" > <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2150, "\"", 2195, 2);
                WriteAttributeValue("", 2157, "/Comentario/Excluir?id=", 2157, 23, true);
#line 73 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
WriteAttributeValue("", 2180, c.IdComentario, 2180, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2196, 67, true);
                WriteLiteral(">Rejeitar</a></button>\r\n               <button class=\"Aprovar\">  <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 2263, "\"", 2316, 2);
                WriteAttributeValue("", 2270, "/Comentario/ListarAprovados?id=", 2270, 31, true);
#line 74 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
WriteAttributeValue("", 2301, c.IdComentario, 2301, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2317, 70, true);
                WriteLiteral(">Aprovar</a></button>\r\n            </td>\r\n           \r\n        </tr>\r\n");
                EndContext();
#line 78 "C:\Users\52742298835\Desktop\Carfel\Views\Administrador\Administrar.cshtml"
                
        }

#line default
#line hidden
                BeginContext(2416, 18, true);
                WriteLiteral("   </table> \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2441, 601, true);
            WriteLiteral(@"
    </section>
    
    <footer>
            <section>
                <div class=""chao"">
                    <h4>Desenvolvido por Enzo Romano Panebianco ©</h4>
                    <p>E-mail:panebianco.enzo@yahoo.com.br </p>
                    
                    <a href=""#"">
                    <img src=""/imagem/Facebook_Home_logo_old.svg.png"" alt=""facebook da empresa"">
                    </a>
                    <img src=""/imagem/instagram-colourful-icon.png"" alt=""instagram da empresa"">
                </div>
              
            </section>
        </footer>
</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
