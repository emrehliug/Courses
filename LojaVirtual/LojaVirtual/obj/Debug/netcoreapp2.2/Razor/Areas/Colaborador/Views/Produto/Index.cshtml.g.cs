#pragma checksum "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cac790c5c351d1b0b22ee96399428083cbf2bf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index), @"mvc.1.0.view", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Colaborador/Views/Produto/Index.cshtml", typeof(AspNetCore.Areas_Colaborador_Views_Produto_Index))]
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
#line 3 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 4 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 6 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 7 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 8 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#line 10 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 11 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
#line 12 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 13 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Pedido;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cac790c5c351d1b0b22ee96399428083cbf2bf1", @"/Areas/Colaborador/Views/Produto/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1322751b8c9396839f0af7ffaba376da28555d8d", @"/Areas/Colaborador/Views/_ViewImports.cshtml")]
    public class Areas_Colaborador_Views_Produto_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<LojaVirtual.Models.ProdutoAgregador.Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastrar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Atualizar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Excluir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
  
    ViewData["Title"] = "Index";
    var pesquisa = Context.Request.Query["pesquisa"];

#line default
#line hidden
            BeginContext(172, 148, true);
            WriteLiteral("\r\n<h1>Produto</h1>\r\n\r\n<br />\r\n<br />\r\n<!--\r\n    Formulário\r\n    -- QueryString: Colaborador/Cliente/Index?pesquisa={palavraDigitada}&pagina=3\r\n-->\r\n");
            EndContext();
            BeginContext(320, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cac790c5c351d1b0b22ee96399428083cbf2bf17492", async() => {
                BeginContext(339, 128, true);
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <label for=\"pesquisa\"></label>\r\n        <input type=\"text\" name=\"pesquisa\" id=\"pesquisa\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 467, "\"", 484, 1);
#line 18 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
WriteAttributeValue("", 475, pesquisa, 475, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(485, 138, true);
                WriteLiteral(" class=\"form-control\" placeholder=\"Digite o nome do produto\">\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">OK</button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(630, 20, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n\r\n");
            EndContext();
#line 25 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
   await Html.RenderPartialAsync("~/Views/Shared/_Mensagem.cshtml"); 

#line default
#line hidden
            BeginContext(722, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(724, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cac790c5c351d1b0b22ee96399428083cbf2bf110176", async() => {
                BeginContext(774, 9, true);
                WriteLiteral("Cadastrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
            BeginContext(787, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 29 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
 if (Model.Count > 0)
{


#line default
#line hidden
            BeginContext(819, 161, true);
            WriteLiteral("    <div class=\"table-responsive\">\r\n        <table class=\"table table-bordered\">\r\n            <thead>\r\n                <tr>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(981, 46, false);
#line 36 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Id));

#line default
#line hidden
            EndContext();
            BeginContext(1027, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1071, 48, false);
#line 37 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Nome));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1163, 53, false);
#line 38 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 43, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">");
            EndContext();
            BeginContext(1260, 49, false);
#line 39 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.First().Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 121, true);
            WriteLiteral("</th>\r\n                    <th scope=\"col\">Ações</th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 44 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                 foreach (Produto produto in Model)
                {

#line default
#line hidden
            BeginContext(1502, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(1569, 10, false);
#line 47 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                   Write(produto.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1579, 35, true);
            WriteLiteral("</th>\r\n                        <td>");
            EndContext();
            BeginContext(1615, 12, false);
#line 48 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(1627, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1663, 19, false);
#line 49 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.CategoriaId);

#line default
#line hidden
            EndContext();
            BeginContext(1682, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1718, 13, false);
#line 50 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                       Write(produto.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(1731, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1796, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cac790c5c351d1b0b22ee96399428083cbf2bf115872", async() => {
                BeginContext(1875, 9, true);
                WriteLiteral("Atualizar");
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
#line 52 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                        WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1888, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1918, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cac790c5c351d1b0b22ee96399428083cbf2bf118343", async() => {
                BeginContext(1992, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                      WriteLiteral(produto.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2003, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 56 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(2082, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2141, 115, false);
#line 61 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
Write(Html.PagedListPager((IPagedList)Model, pagina => Url.Action("Index", new { pagina = pagina, pesquisa = pesquisa })));

#line default
#line hidden
            EndContext();
#line 61 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
                                                                                                                        

}
else
{

#line default
#line hidden
            BeginContext(2272, 46, true);
            WriteLiteral("    <span>Nenhum registro cadastrado!</span>\r\n");
            EndContext();
#line 67 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Colaborador\Views\Produto\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<LojaVirtual.Models.ProdutoAgregador.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
