#pragma checksum "C:\Users\52742298835\Desktop\Projetao\Projeto.CheckPoint\Views\Comentario\ListarAprovados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed4b1acbc044296acd97b2340dd65b0f97a39b16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comentario_ListarAprovados), @"mvc.1.0.view", @"/Views/Comentario/ListarAprovados.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comentario/ListarAprovados.cshtml", typeof(AspNetCore.Views_Comentario_ListarAprovados))]
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
#line 1 "C:\Users\52742298835\Desktop\Projetao\Projeto.CheckPoint\Views\Comentario\ListarAprovados.cshtml"
using Projeto.CheckPoint.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed4b1acbc044296acd97b2340dd65b0f97a39b16", @"/Views/Comentario/ListarAprovados.cshtml")]
    public class Views_Comentario_ListarAprovados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            BeginContext(60, 324, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29e67549250a446aa9d13855baec5fa2", async() => {
                BeginContext(66, 311, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Page Title</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" type=""text/css"" media=""screen"" href=""main.css"" />
    <script src=""main.js""></script>
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
            BeginContext(384, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(386, 401, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb1b8e31ba41457982c1efdf4937ed7d", async() => {
                BeginContext(392, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "C:\Users\52742298835\Desktop\Projetao\Projeto.CheckPoint\Views\Comentario\ListarAprovados.cshtml"
      
        ComentarioModel comentario = ViewBag.Comentario;
    

#line default
#line hidden
                BeginContext(467, 98, true);
                WriteLiteral("     <form action=\"/Comentario/Alterar\" method=\"POST\">\r\n     \r\n     <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 565, "\"", 597, 1);
#line 18 "C:\Users\52742298835\Desktop\Projetao\Projeto.CheckPoint\Views\Comentario\ListarAprovados.cshtml"
WriteAttributeValue("", 573, comentario.IdComentario, 573, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(598, 75, true);
                WriteLiteral(">\r\n\r\n     <label>\r\n         Status\r\n         <input type=\"text\" name=\"tipo\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 673, "\"", 697, 1);
#line 22 "C:\Users\52742298835\Desktop\Projetao\Projeto.CheckPoint\Views\Comentario\ListarAprovados.cshtml"
WriteAttributeValue("", 681, comentario.Tipo, 681, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 82, true);
                WriteLiteral(">\r\n     </label>\r\n     <button type=\"submit\">Enviar</button>\r\n     </form>\r\n    \r\n");
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
            BeginContext(787, 9, true);
            WriteLiteral("\r\n</html>");
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