#pragma checksum "C:\Users\52450072829\Documents\RoleTopMVC\Views\Orcamento\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a073e4602d0c4d2d5f5de4d05c2c4449a7a1547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orcamento_Index), @"mvc.1.0.view", @"/Views/Orcamento/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orcamento/Index.cshtml", typeof(AspNetCore.Views_Orcamento_Index))]
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
#line 1 "C:\Users\52450072829\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\52450072829\Documents\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a073e4602d0c4d2d5f5de4d05c2c4449a7a1547", @"/Views/Orcamento/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Orcamento_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.OrcamentoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(50, 149, true);
            WriteLiteral("\r\n <main>  \r\n                        <h2>Faça sua Reserva!</h2>\r\n                        <br>\r\n                        <br>\r\n                        ");
            EndContext();
            BeginContext(199, 4831, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a073e4602d0c4d2d5f5de4d05c2c4449a7a15473901", async() => {
                BeginContext(265, 4758, true);
                WriteLiteral(@"

                            <div class=""in-esquerda"">
                                <div>
                                    <label for=""Nome do evento""> Nome do Evento:</label>
                                    <br>
                                    <input id=""nome evento"" type=""text"" name=""nome-evento"" required>
                                </div>
                                <div>
                                    <label for=""Tipo de Evento"">Tipo de Evento:</label>
                                    <br>
                                    <input id=""tipo evento"" type=""text"" name=""tipo-evento"" required>
                                </div>
                                <div>
                                    <label for=""numero de pessoas"">Número de Pessoas:</label>
                                    <br>
                                    <input id=""numero de pessoas"" type=""text"" name=""quantidade"" required>
                                </div>
                 ");
                WriteLiteral(@"                 <div>
                                    <label for=""Data"">Data do Evento:</label>
                                    <br>
                                    <input id=""dataevento"" type=""date"" name=""dataevento"" required>
                                </div>
                                
                                <div>
                                    <label for=""E-mail"">E-mail:</label>
                                    <br>
                                    <input id=""email"" type=""email"" name=""email"">
                                </div>
                               
                                <div>
                                    <label for=""Observações"">Observações:</label>
                                    <br>
                                    <input id=""observações"" type=""text-box"" name=""observacoes"" required>
                                </div>
                            </div>
                            <div class=""meio"">
  ");
                WriteLiteral(@"                              <div>
                                    <input type=""checkbox"" name=""serviço de aúdio"" 
                                    value=""áudio""> Necessário serviço de áudio  <br> 
                                </div> 
                                <div>
                                    <input type=""checkbox"" name=""serviço de iluminação""
                                    value=""som""> Necessário serviço de iluminação<br> 
                                </div> 
                              
                                <h3>Formas de pagamento</h3>
                                <p>Total a pagar : R$10.000</p>
                                <div>
                                    <input  type=""checkbox"" name=""Cartão de Crédito""
                                    value=""Crédito""> Cartão de Crédito<br>
                                </div>
                                
                                <div>
                                    <input t");
                WriteLiteral(@"ype=""checkbox"" name=""boleto bancário""
                                    value=""Boleto"">Boleto Bancário<br>
                                </div>
                                
                                <input type=""checkbox"" name=""transferência""
                                value=""transferência""> Transferência <ul>
                                </div>
                                <div class=""direita"">
                                        <h3>Informações</h3>
                                        <li>
                                            N° da conta:5546798
                                        </li>
                                        <li>
                                            Agência:023456
                                        </li>
                                        <li>
                                            Banco Bradesco
                                        </li>
                                    </ul>
                       ");
                WriteLiteral(@"             <br>
                                    <br>
                                    <h3>Observações de cancelamento:</h3><p>O cancelamento pode ser feito com até 3 dias de antecedência do evento.<br>
                                        Caso contrário, o indivíduo terá de pagar metade do aluguel do local.</p>
                                    </div>
                            <div class=""fim"">
                                <input type=""submit"" value=""Finalizar""/>
                            </div>                
                    
                                

                                
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 7 "C:\Users\52450072829\Documents\RoleTopMVC\Views\Orcamento\Index.cshtml"
AddHtmlAttributeValue("", 227, Url.Action("Registrar","Orcamento"), 227, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5030, 37, true);
            WriteLiteral("\r\n                            </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.OrcamentoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
