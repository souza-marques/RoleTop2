#pragma checksum "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c362a98641e0cdde9d459beea5473212531892db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Historico), @"mvc.1.0.view", @"/Views/Cliente/Historico.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cliente/Historico.cshtml", typeof(AspNetCore.Views_Cliente_Historico))]
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
#line 1 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c362a98641e0cdde9d459beea5473212531892db", @"/Views/Cliente/Historico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Cliente_Historico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.HistoricoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
  
    ViewData["Title"] = "Reservas - RoleTop";
    ViewData["H2"] = "Histórico de Eventos";

#line default
#line hidden
            BeginContext(149, 18, true);
            WriteLiteral("\r\n<main>\r\n    <h2>");
            EndContext();
            BeginContext(168, 14, false);
#line 8 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
   Write(ViewData["H2"]);

#line default
#line hidden
            EndContext();
            BeginContext(182, 205, true);
            WriteLiteral("</h2>\r\n    <table>\r\n        <thead>\r\n            <tr>\r\n                <th>Data do Evento</th>\r\n                <th>Nome do Evento</th>\r\n            \r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 18 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
             foreach ( var orcamento in Model.Orcamentos){

#line default
#line hidden
            BeginContext(447, 46, true);
            WriteLiteral("                <tr>\r\n\r\n                  <td>");
            EndContext();
            BeginContext(494, 20, false);
#line 21 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                 Write(orcamento.Dataevento);

#line default
#line hidden
            EndContext();
            BeginContext(514, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(546, 21, false);
#line 22 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Nome_evento);

#line default
#line hidden
            EndContext();
            BeginContext(567, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 24 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(612, 41, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.HistoricoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
