#pragma checksum "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2004cccb6647604386f29ed9da2bd1b62cdb311"
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
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Web;

#line default
#line hidden
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Domain;

#line default
#line hidden
#line 3 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\_ViewImports.cshtml"
using ControleDeGastos.Service;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2004cccb6647604386f29ed9da2bd1b62cdb311", @"/Views/Cartao/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Cartao_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("blockquote blockquote-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("cursor: pointer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger btn-round btn-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
  
    ViewData["Title"] = "CdG - Meus cartões";

#line default
#line hidden
            BeginContext(54, 562, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 100%;"">
                <div class=""card-header"">
                    <h5 style=""text-align: center;""><small>Estes são os <b>cartões</b> que você cadastrou.</small></h5>
                    <p class=""text-info"" style=""text-align:center;""> Você pode adicionar um novo clicando no botão ao lado.</p>
                    <div class=""row"" style=""margin-left: 5px; margin-top: -70px; text-transform: uppercase;"">
                        ");
            EndContext();
            BeginContext(616, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fb1ca7e790840c4aae3672376f6ad3b", async() => {
                BeginContext(703, 35, true);
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
            BeginContext(742, 97, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 18 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                     if (ViewBag.Cartoes.Count == 0)
                    {

#line default
#line hidden
            BeginContext(916, 113, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ CARTÕES CADASTRADOS</b></p>\r\n");
            EndContext();
#line 21 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1101, 738, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                    <th>Agência</th>
                                    <th>Banco</th>
                                    <th>Conta</th>
                                    <th>CVV</th>
                                    <th>Validade</th>
                                    <th>Dia vencimento</th>
                                    <th>Nome cartão</th>
                                    <th>Número</th>
                                    <th>Tipo</th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 38 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                     foreach (Cartao item in ViewBag.Cartoes)
                                    {

#line default
#line hidden
            BeginContext(1957, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2102, 12, false);
#line 42 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Agencia);

#line default
#line hidden
            EndContext();
            BeginContext(2114, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2266, 10, false);
#line 45 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Banco);

#line default
#line hidden
            EndContext();
            BeginContext(2276, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2428, 10, false);
#line 48 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Conta);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2590, 8, false);
#line 51 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Cvv);

#line default
#line hidden
            EndContext();
            BeginContext(2598, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2750, 40, false);
#line 54 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.DataValidade.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2790, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2942, 18, false);
#line 57 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.DiaVencimento);

#line default
#line hidden
            EndContext();
            BeginContext(2960, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3112, 18, false);
#line 60 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.NomeSobrenome);

#line default
#line hidden
            EndContext();
            BeginContext(3130, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3282, 11, false);
#line 63 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Numero);

#line default
#line hidden
            EndContext();
            BeginContext(3293, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3445, 9, false);
#line 66 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                           Write(item.Tipo);

#line default
#line hidden
            EndContext();
            BeginContext(3454, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3605, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e55ea79a86d4fc79a79da79ac19fb3b", async() => {
                BeginContext(3722, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
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
#line 69 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
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
            BeginContext(3753, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 72 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3892, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 76 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Cartao\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4027, 92, true);
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
