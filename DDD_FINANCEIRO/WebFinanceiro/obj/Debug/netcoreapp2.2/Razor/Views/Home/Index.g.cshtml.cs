#pragma checksum "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b9e3f3cfba7a5dec891dc9d3a9aef9ba3b2029"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b9e3f3cfba7a5dec891dc9d3a9aef9ba3b2029", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadf92a28c028c939eb51d8d522461abd2f872e0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/graficos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = " ";

#line default
#line hidden
            BeginContext(37, 1613, true);
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""card card-stats"">
                    <div class=""card-header card-header-info card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""material-icons"">content_copy</i>
                        </div>
                        <p class=""card-category"">Investimentos</p>
                        <h3 class=""card-title"">R$ <span id=""Investimento""></span></h3>
                    </div>
                    <div class=""card-footer"">
                        <div class=""stats"">
                            <i class=""material-icons text-danger"">warning</i>
                            <a href=""#"">Off...</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""card card");
            WriteLiteral(@"-stats"">
                    <div class=""card-header card-header-success card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""material-icons"">store</i>
                        </div>
                        <p class=""card-category"">Despesas Pagas</p>
                        <h3 class=""card-title"">R$ <span id=""Despesa_Paga""></span></h3>
                    </div>
                    <div class=""card-footer"">
                        <div class=""stats"">
                            <i class=""material-icons"">date_range</i>Mês ");
            EndContext();
            BeginContext(1651, 18, false);
#line 36 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Home\Index.cshtml"
                                                                   Write(DateTime.Now.Month);

#line default
#line hidden
            EndContext();
            BeginContext(1669, 340, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""card card-stats"">
                    <div class=""card-header card-header-warning card-header-icon"">
                        <div class=""card-icon"">
");
            EndContext();
            BeginContext(2085, 446, true);
            WriteLiteral(@"                            <i class=""fa fa-warning""></i>
                        </div>
                        <p class=""card-category"">Despesas a Pagar</p>
                        <h3 class=""card-title"">R$ <span id=""Despesa_Pendente""></span></h3>
                    </div>
                    <div class=""card-footer"">
                        <div class=""stats"">
                            <i class=""material-icons"">date_range</i>Mês ");
            EndContext();
            BeginContext(2532, 18, false);
#line 53 "C:\ProjetosVSOnline\DDD_FINANCEIRO\WebFinanceiro\Views\Home\Index.cshtml"
                                                                   Write(DateTime.Now.Month);

#line default
#line hidden
            EndContext();
            BeginContext(2550, 894, true);
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6 col-sm-6"">
                <div class=""card card-stats"">
                    <div class=""card-header card-header-danger card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""fa fa-money""></i>
                        </div>

                        <p class=""card-category"">Despesas atrasadas</p>
                        <h3 class=""card-title"">R$ <span id=""Despesa_atrasadas""></span></h3>
                    </div>
                    <div class=""card-footer"">
                        <div class=""stats"">
                            <i class=""material-icons"">date_range</i>Tudo
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
            BeginContext(4277, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
            BeginContext(6812, 3742, true);
            WriteLiteral(@"        <div class=""row"">
            <div class=""col-lg-6 col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-tabs card-header-primary"">
                        <div class=""nav-tabs-navigation"">
                            <div class=""nav-tabs-wrapper"">
                                <span class=""nav-tabs-title"">Info:</span>
                                <ul class=""nav nav-tabs"" data-tabs=""tabs"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" href=""#profile"" data-toggle=""tab"">
                                            <i class=""material-icons"">bug_report</i> Bugs
                                            <div class=""ripple-container""></div>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#messages"" d");
            WriteLiteral(@"ata-toggle=""tab"">
                                            <i class=""material-icons"">code</i> Website
                                            <div class=""ripple-container""></div>
                                        </a>
                                    </li>
                                    <li class=""nav-item"">
                                        <a class=""nav-link"" href=""#settings"" data-toggle=""tab"">
                                            <i class=""material-icons"">cloud</i> Server
                                            <div class=""ripple-container""></div>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                    <div class=""card-body"">
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""profile"">
                            ");
            WriteLiteral(@"    <table class=""table"">
                                    <tbody>
                                        <tr>
                                            <td>
                                                <div class=""form-check"">
                                                    <label class=""form-check-label"">
                                                        <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                        <span class=""form-check-sign"">
                                                            <span class=""check""></span>
                                                        </span>
                                                    </label>
                                                </div>
                                            </td>
                                            <td>Nenhum Bug Reportado</td>
                                            <td class=""td-actions text-right"">
       ");
            WriteLiteral(@"                                         <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                    <i class=""material-icons"">edit</i>
                                                </button>
                                                <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                    <i class=""material-icons"">close</i>
                                                </button>
                                            </td>
                                        </tr>
");
            EndContext();
            BeginContext(15685, 2013, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""tab-pane"" id=""messages"">
                                <table class=""table"">
                                    <tbody>
                                        <tr>
                                            <td>
                                                <div class=""form-check"">
                                                    <label class=""form-check-label"">
                                                        <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                        <span class=""form-check-sign"">
                                                            <span class=""check""></span>
                                                        </span>
                                                    </label>
                                                </d");
            WriteLiteral(@"iv>
                                            </td>
                                            <td>
                                                Tudo funcionando por aqui
                                            </td>
                                            <td class=""td-actions text-right"">
                                                <button type=""button"" rel=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                    <i class=""material-icons"">edit</i>
                                                </button>
                                                <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                    <i class=""material-icons"">close</i>
                                                </button>
                                            </td>
                                        </tr>
");
            EndContext();
            BeginContext(19357, 290, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                            </div>
                            <div class=""tab-pane"" id=""settings"">
                                <table class=""table"">
                                    <tbody>
");
            EndContext();
            BeginContext(23124, 1903, true);
            WriteLiteral(@"                                        <tr>
                                            <td>
                                                <div class=""form-check"">
                                                    <label class=""form-check-label"">
                                                        <input class=""form-check-input"" type=""checkbox"" value="""" checked>
                                                        <span class=""form-check-sign"">
                                                            <span class=""check""></span>
                                                        </span>
                                                    </label>
                                                </div>
                                            </td>
                                            <td>Serviço processamento On...</td>
                                            <td class=""td-actions text-right"">
                                                <button type=""button"" re");
            WriteLiteral(@"l=""tooltip"" title=""Edit Task"" class=""btn btn-primary btn-link btn-sm"">
                                                    <i class=""material-icons"">edit</i>
                                                </button>
                                                <button type=""button"" rel=""tooltip"" title=""Remove"" class=""btn btn-danger btn-link btn-sm"">
                                                    <i class=""material-icons"">close</i>
                                                </button>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6 col-md-12"">
");
            EndContext();
            BeginContext(27055, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(27113, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b9e3f3cfba7a5dec891dc9d3a9aef9ba3b202917349", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(27164, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(27168, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69b9e3f3cfba7a5dec891dc9d3a9aef9ba3b202918535", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(27208, 230, true);
            WriteLiteral("\r\n\r\n<script>\r\n    window.addEventListener(\'load\', function () {\r\n\r\n        $(\'#Dashboard\').addClass(\'active\');\r\n        $(\'#Categorias\').removeClass(\'active\');\r\n        $(\'#Despesas\').removeClass(\'active\');\r\n\r\n    });\r\n\r\n</script>");
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
