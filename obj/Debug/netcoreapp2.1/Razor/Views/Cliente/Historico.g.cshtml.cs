#pragma checksum "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "693852d5d9619470bc59c1f6b00787de66ed153d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"693852d5d9619470bc59c1f6b00787de66ed153d", @"/Views/Cliente/Historico.cshtml")]
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
            BeginContext(182, 294, true);
            WriteLiteral(@"</h2>
    <table>
        <thead>
            <tr>
                <td>Quantidade de Pessoas</td>
                <th>Data do Evento</th>
                <th>Tipo de Evento</th>
                <th>Nome do Evento</th>
            
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 20 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
             foreach ( var orcamento in Model.Orcamentos){

#line default
#line hidden
            BeginContext(536, 44, true);
            WriteLiteral("                <tr>\r\n                  <td>");
            EndContext();
            BeginContext(581, 20, false);
#line 22 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                 Write(orcamento.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(601, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(631, 20, false);
#line 23 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                 Write(orcamento.Dataevento);

#line default
#line hidden
            EndContext();
            BeginContext(651, 29, true);
            WriteLiteral("</td>\r\n                  <td>");
            EndContext();
            BeginContext(681, 21, false);
#line 24 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                 Write(orcamento.Tipo_evento);

#line default
#line hidden
            EndContext();
            BeginContext(702, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(734, 21, false);
#line 25 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
                   Write(orcamento.Nome_evento);

#line default
#line hidden
            EndContext();
            BeginContext(755, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 27 "C:\Users\marqu\OneDrive\Documentos\RoleTop2\Views\Cliente\Historico.cshtml"
            }

#line default
#line hidden
            BeginContext(800, 41, true);
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
