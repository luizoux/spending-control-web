#pragma checksum "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04dea8c749e416a4538393d5acd8df8fde749578"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Meta_Index), @"mvc.1.0.view", @"/Views/Meta/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Meta/Index.cshtml", typeof(AspNetCore.Views_Meta_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04dea8c749e416a4538393d5acd8df8fde749578", @"/Views/Meta/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c1d0c3afc2fe50c127441ccd7d2370ff34a29b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Meta_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Meta>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-primary btn-round btn-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Meta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Conquistada", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-danger btn-round btn-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remover", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
  
    ViewData["Title"] = "CdG - Minhas metas";

#line default
#line hidden
            BeginContext(67, 538, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""card"" style=""width: 50%;"">
                <div class=""card-header"">
                    <h5 style=""text-align: center;""><small>Estas são as <b>metas</b> que você cadastrou.</small></h5>
                    <p class=""text-info"" style=""text-align:center;"">Escolha a data final que pretende realizar essa meta e sua descrição nos campos abaixo. Depois clique no <b>+</b> para cadastrar.</p>
                </div>
                ");
            EndContext();
            BeginContext(605, 1473, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed4d5f0c3d65462fa62705038f30eb69", async() => {
                BeginContext(678, 400, true);
                WriteLiteral(@"
                    <div class=""row"" style=""width: 98%; margin-left: 1%;"">
                        <div class=""col-md-2"" style=""margin-right: -11%; margin-top: 2%;"">
                            <p class=""text-black"">Até</p>
                        </div>
                        <div class=""col-md-4 pr-1"">
                            <div class=""form-group"">
                                ");
                EndContext();
                BeginContext(1078, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cb8585d20324223a2808c63753fe187", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 21 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DataFinal);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1128, 428, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-2 pr-1"" style=""margin-right: -7%; margin-top: 2%;"">
                            <p class=""text-black"">pretendo</p>
                        </div>
                        <div class=""col-md-5 pr-1"" style=""margin-right: -7%;"">
                            <div class=""form-group"">
                                ");
                EndContext();
                BeginContext(1556, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2fb06056ff2c43a0bad559133fec40a1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 29 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Texto);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1620, 451, true);
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-md-2 pr-1"">
                            <div class=""form-group"">
                                <button type=""submit"" class=""btn btn-success btn-round"" style=""margin-top: 1.6%; margin-left: 40%;"" value=""Cadastrar"">+</button>
                            </div>
                        </div>
                    </div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2078, 43, true);
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n");
            EndContext();
#line 40 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                     if (ViewBag.Metas.Count == 0)
                    {

#line default
#line hidden
            BeginContext(2196, 111, true);
            WriteLiteral("                        <p class=\"text-danger\" style=\"text-align:center;\"><b>NÃO HÁ METAS CADASTRADAS</b></p>\r\n");
            EndContext();
#line 43 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"

                    }
                    else
                    {

#line default
#line hidden
            BeginContext(2381, 620, true);
            WriteLiteral(@"                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class=""text-primary"">
                                <th>
                                    Meta
                                </th>
                                <th>
                                    Conquistada!
                                </th>
                                <th>
                                    Remover
                                </th>
                                </thead>
                                <tbody>
");
            EndContext();
#line 61 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                     foreach (Meta item in ViewBag.Metas)
                                    {

#line default
#line hidden
            BeginContext(3115, 46, true);
            WriteLiteral("                                        <tr>\r\n");
            EndContext();
#line 64 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                             if (item.Conquistada)
                                            {

#line default
#line hidden
            BeginContext(3276, 170, true);
            WriteLiteral("                                                <td>\r\n                                                    <div class=\"text-success\" style=\"text-decoration:line-through;\">");
            EndContext();
            BeginContext(3447, 10, false);
#line 67 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                                                                                               Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(3457, 5, true);
            WriteLiteral(" até ");
            EndContext();
            BeginContext(3463, 42, false);
#line 67 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                                                                                                               Write(item.DataFinal.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3505, 63, true);
            WriteLiteral("</div>\r\n                                                </td>\r\n");
            EndContext();
#line 69 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(3712, 106, true);
            WriteLiteral("                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(3819, 10, false);
#line 73 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                               Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(3829, 5, true);
            WriteLiteral(" até ");
            EndContext();
            BeginContext(3835, 42, false);
#line 73 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                                               Write(item.DataFinal.Date.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3877, 57, true);
            WriteLiteral("\r\n                                                </td>\r\n");
            EndContext();
#line 75 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3981, 98, true);
            WriteLiteral("                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4079, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0fad1f18aad4372b4f4ec68df2c88c4", async() => {
                BeginContext(4219, 26, true);
                WriteLiteral("<i class=\"fa fa-star\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idMeta", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                                                                                                                         WriteLiteral(item.IdMeta);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMeta"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idMeta", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMeta"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4249, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4400, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e265eee8534572a8756169523d4dcc", async() => {
                BeginContext(4535, 27, true);
                WriteLiteral("<i class=\"fa fa-trash\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idMeta", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                                                                                                                        WriteLiteral(item.IdMeta);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMeta"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idMeta", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idMeta"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4566, 100, true);
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 83 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4705, 112, true);
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n");
            EndContext();
#line 87 "C:\Users\gabri\OneDrive\Área de Trabalho\controle-de-gastos-web\ControleDeGastos.Web\Views\Meta\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4840, 80, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Meta> Html { get; private set; }
    }
}
#pragma warning restore 1591
