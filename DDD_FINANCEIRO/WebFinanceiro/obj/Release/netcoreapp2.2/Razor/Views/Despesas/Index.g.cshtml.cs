#pragma checksum "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "834cb7c15f1e23baa4661dd165a1117a1971334e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Despesas_Index), @"mvc.1.0.view", @"/Views/Despesas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Despesas/Index.cshtml", typeof(AspNetCore.Views_Despesas_Index))]
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
#line 1 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\_ViewImports.cshtml"
using WebFinanceiro;

#line default
#line hidden
#line 2 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\_ViewImports.cshtml"
using WebFinanceiro.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"834cb7c15f1e23baa4661dd165a1117a1971334e", @"/Views/Despesas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadf92a28c028c939eb51d8d522461abd2f872e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Despesas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Entities.Entidades.Despesa>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/despesa.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 296, true);
            WriteLiteral(@"



<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-primary"">
                        <h4 class=""card-title "">Despesas</h4>
");
            EndContext();
            BeginContext(430, 144, true);
            WriteLiteral("                        <p class=\"card-category\">\r\n                            <i class=\"material-icons\">class</i>\r\n                            ");
            EndContext();
            BeginContext(574, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834cb7c15f1e23baa4661dd165a1117a1971334e5494", async() => {
                BeginContext(597, 22, true);
                WriteLiteral("Criar uma nova Despesa");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(623, 467, true);
            WriteLiteral(@"
                        </p>

                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead class="" text-primary"">
                                    <tr>
                                        <th>Ações</th>

                                        <th>
                                            ");
            EndContext();
            BeginContext(1091, 40, false);
#line 28 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1271, 47, false);
#line 31 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.TipoDespesa));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1458, 41, false);
#line 34 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1639, 48, false);
#line 37 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(1827, 50, false);
#line 40 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DataVencimento));

#line default
#line hidden
            EndContext();
            BeginContext(1877, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2017, 49, false);
#line 43 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.DataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(2066, 139, true);
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
            EndContext();
            BeginContext(2206, 40, false);
#line 46 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(2246, 175, true);
            WriteLiteral("\r\n                                        </th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 51 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(2526, 144, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(2670, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834cb7c15f1e23baa4661dd165a1117a1971334e11594", async() => {
                BeginContext(2715, 6, true);
                WriteLiteral("Edição");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2725, 52, true);
            WriteLiteral(" |\r\n                                                ");
            EndContext();
            BeginContext(2777, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834cb7c15f1e23baa4661dd165a1117a1971334e14003", async() => {
                BeginContext(2825, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2837, 52, true);
            WriteLiteral(" |\r\n                                                ");
            EndContext();
            BeginContext(2889, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834cb7c15f1e23baa4661dd165a1117a1971334e16417", async() => {
                BeginContext(2936, 7, true);
                WriteLiteral("Deletar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2947, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3099, 39, false);
#line 60 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3138, 107, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n\r\n                                            <td>\r\n");
            EndContext();
#line 65 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                 if (item.TipoDespesa == Entities.Enums.EnumTipoDespesa.Contas)
                                                {

#line default
#line hidden
            BeginContext(3409, 73, true);
            WriteLiteral("                                                    <span>Contas</span>\r\n");
            EndContext();
#line 68 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3638, 79, true);
            WriteLiteral("                                                    <span>Investimento</span>\r\n");
            EndContext();
#line 72 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3768, 151, true);
            WriteLiteral("                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(3920, 40, false);
#line 76 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3960, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4112, 47, false);
#line 79 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.DataCadastro));

#line default
#line hidden
            EndContext();
            BeginContext(4159, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4311, 49, false);
#line 82 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.DataVencimento));

#line default
#line hidden
            EndContext();
            BeginContext(4360, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4512, 48, false);
#line 85 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.DataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(4560, 151, true);
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(4712, 39, false);
#line 88 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(4751, 104, true);
            WriteLiteral("\r\n                                            </td>\r\n\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 93 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(4894, 226, true);
            WriteLiteral("\r\n                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(5138, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 107 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Despesas\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
            BeginContext(5211, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5213, 39, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "834cb7c15f1e23baa4661dd165a1117a1971334e24479", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5252, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Entities.Entidades.Despesa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
