#pragma checksum "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0972c73855eb00e10245d91597332bda663ad7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cartao_Index), @"mvc.1.0.view", @"/Views/Cartao/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cartao/Index.cshtml", typeof(AspNetCore.Views_Cartao_Index))]
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
#line 1 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web;

#line default
#line hidden
#line 2 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Domain;

#line default
#line hidden
#line 3 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Service;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0972c73855eb00e10245d91597332bda663ad7a", @"/Views/Cartao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cartao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blockquote blockquote-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor: pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
  
    ViewData["Title"] = "CdG - Meus cartões";

#line default
#line hidden
            BeginContext(54, 487, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 100%;"">
                <div class=""card-header"">
                    <h5 style=""text-align: center;""><small>Estes são os cartões que você cadastrou. </br> Você pode adicionar um novo clicando no botão ao lado.</small></h5>
                    <div class=""row"" style=""margin-left: 5px; margin-top: -80px; text-transform: uppercase;"">
                        ");
            EndContext();
            BeginContext(541, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf5d52e6ca4e4a7186326bd8e1a8d4f8", async() => {
                BeginContext(628, 35, true);
                WriteLiteral("<small><b>+ Novo cartão</b></small>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(667, 97, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 17 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                     if (ViewBag.Cartoes.Count == 0)
                    {

#line default
#line hidden
            BeginContext(841, 113, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ CARTÕES CADASTRADOS</b></p>\r\n");
            EndContext();
#line 20 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1026, 753, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                    <th>Agência</th>
                                    <th>Banco</th>
                                    <th>Conta</th>
                                    <th>CVV</th>
                                    <th>Validade</th>
                                    <th>Dia de vencimento</th>
                                    <th>Nome impresso no cartão</th>
                                    <th>Número</th>
                                    <th>Tipo</th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 37 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                     foreach (Cartao item in ViewBag.Cartoes)
                                    {

#line default
#line hidden
            BeginContext(1897, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2042, 12, false);
#line 41 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Agencia);

#line default
#line hidden
            EndContext();
            BeginContext(2054, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2206, 10, false);
#line 44 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Banco);

#line default
#line hidden
            EndContext();
            BeginContext(2216, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2368, 10, false);
#line 47 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Conta);

#line default
#line hidden
            EndContext();
            BeginContext(2378, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2530, 8, false);
#line 50 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Cvv);

#line default
#line hidden
            EndContext();
            BeginContext(2538, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2690, 40, false);
#line 53 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.DataValidade.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2730, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2882, 18, false);
#line 56 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.DiaVencimento);

#line default
#line hidden
            EndContext();
            BeginContext(2900, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3052, 18, false);
#line 59 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.NomeSobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(3070, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3222, 11, false);
#line 62 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(3233, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3385, 9, false);
#line 65 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(3394, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3545, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c38a8579c73d49a4b27933f584dfcece", async() => {
                BeginContext(3628, 1, true);
                WriteLiteral("X");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idCartao", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 68 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                                                                  WriteLiteral(item.IdCartao);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCartao"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idCartao", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idCartao"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3633, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 71 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3772, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 75 "C:\Users\Aluno\Desktop\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(3907, 92, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
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
