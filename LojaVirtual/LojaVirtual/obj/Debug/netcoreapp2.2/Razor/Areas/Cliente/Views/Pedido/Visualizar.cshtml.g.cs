#pragma checksum "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0879198662b3bb72fe036151665641a608d87b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Pedido_Visualizar), @"mvc.1.0.view", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cliente/Views/Pedido/Visualizar.cshtml", typeof(AspNetCore.Areas_Cliente_Views_Pedido_Visualizar))]
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
#line 3 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#line 4 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#line 5 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#line 6 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#line 8 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 9 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#line 10 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Json.Resolver;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0879198662b3bb72fe036151665641a608d87b6", @"/Areas/Cliente/Views/Pedido/Visualizar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c06482c6d69c88a4c3bb64f1a8dc72f1babff4e", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Pedido_Visualizar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pedido>
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
        private global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper __PedidoSituacaoViewComponentTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
  
    ViewData["Title"] = "Visualizar";
    TransacaoPagarMe transacao = JsonConvert.DeserializeObject<TransacaoPagarMe>(Model.DadosTransaction);
    List<ProdutoItem> produtos = JsonConvert.DeserializeObject<List<ProdutoItem>>(Model.DadosProdutos, new JsonSerializerSettings() { ContractResolver = new ProdutoItemResolver<List<ProdutoItem>>() });
    var aniversario = DateTime.Parse(transacao.Customer.Birthday);

#line default
#line hidden
            BeginContext(439, 119, true);
            WriteLiteral("<br /><br />\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12 text-center\">\r\n            ");
            EndContext();
            BeginContext(558, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:pedido-situacao", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f0879198662b3bb72fe036151665641a608d87b64995", async() => {
            }
            );
            __PedidoSituacaoViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Areas_Cliente_Views_Pedido_Visualizar.__Generated__PedidoSituacaoViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__PedidoSituacaoViewComponentTagHelper);
#line 12 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
__PedidoSituacaoViewComponentTagHelper.pedido = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("pedido", __PedidoSituacaoViewComponentTagHelper.pedido, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(596, 316, true);
            WriteLiteral(@"
            <br />
            <br />
        </div>
    </div>
    <div class=""row"">
        
        <div class=""col-md-12"">
            <h3>Dados pedido</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""2""><strong>Situação do pedido:</strong> ");
            EndContext();
            BeginContext(913, 14, false);
#line 23 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                                    Write(Model.Situacao);

#line default
#line hidden
            EndContext();
            BeginContext(927, 124, true);
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Cliente:</strong> ");
            EndContext();
            BeginContext(1052, 23, false);
#line 27 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                             Write(transacao.Customer.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1075, 60, true);
            WriteLiteral("</td>\r\n                    <td><strong>Nascimento:</strong> ");
            EndContext();
            BeginContext(1136, 34, false);
#line 28 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                Write(aniversario.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 113, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>Forma de pagamento: </strong>");
            EndContext();
            BeginContext(1284, 20, false);
#line 31 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                        Write(Model.FormaPagamento);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 74, true);
            WriteLiteral("</td>\r\n                    <td><strong>Nota Fiscal Eletrônica: </strong>- ");
            EndContext();
            BeginContext(1379, 9, false);
#line 32 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                              Write(Model.NFE);

#line default
#line hidden
            EndContext();
            BeginContext(1388, 258, true);
            WriteLiteral(@"</td>
                </tr>
            </table>


            <h3>Entrega</h3>
            <table class=""table table-bordered"">
                <tr>
                    <td colspan=""4"">
                        <strong>Endereço de entrega: </strong>");
            EndContext();
            BeginContext(1647, 23, false);
#line 41 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                         Write(transacao.Shipping.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1670, 120, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr>\r\n                    <td><strong>CEP:</strong> ");
            EndContext();
            BeginContext(1791, 34, false);
#line 45 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                         Write(transacao.Shipping.Address.Zipcode);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 56, true);
            WriteLiteral("</td>\r\n                    <td><strong>Estado:</strong> ");
            EndContext();
            BeginContext(1882, 32, false);
#line 46 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 56, true);
            WriteLiteral("</td>\r\n                    <td><strong>Cidade:</strong> ");
            EndContext();
            BeginContext(1971, 31, false);
#line 47 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(2002, 56, true);
            WriteLiteral("</td>\r\n                    <td><strong>Bairro:</strong> ");
            EndContext();
            BeginContext(2059, 39, false);
#line 48 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.Neighborhood);

#line default
#line hidden
            EndContext();
            BeginContext(2098, 116, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\"><strong>Endereço: </strong> ");
            EndContext();
            BeginContext(2215, 33, false);
#line 51 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                           Write(transacao.Shipping.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(2248, 61, true);
            WriteLiteral("</td>\r\n                    <td><strong>Complemento: </strong>");
            EndContext();
            BeginContext(2310, 40, false);
#line 52 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                 Write(transacao.Shipping.Address.Complementary);

#line default
#line hidden
            EndContext();
            BeginContext(2350, 56, true);
            WriteLiteral("</td>\r\n                    <td><strong>Número: </strong>");
            EndContext();
            BeginContext(2407, 39, false);
#line 53 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                            Write(transacao.Shipping.Address.StreetNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2446, 121, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"2\"><strong>Transportadora:</strong> ");
            EndContext();
            BeginContext(2568, 18, false);
#line 56 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                                Write(Model.FreteEmpresa);

#line default
#line hidden
            EndContext();
            BeginContext(2586, 64, true);
            WriteLiteral("</td>\r\n                    <td><strong>Valor do frete:</strong> ");
            EndContext();
            BeginContext(2651, 74, false);
#line 57 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                    Write(Mascara.ConverterPagarMeIntToDecimal(transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(2725, 65, true);
            WriteLiteral("</td>\r\n                    <td><strong>Rastreamento: </strong> - ");
            EndContext();
            BeginContext(2791, 26, false);
#line 58 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                                                     Write(Model.FreteCodRastreamento);

#line default
#line hidden
            EndContext();
            BeginContext(2817, 339, true);
            WriteLiteral(@"</td>
                </tr>
            </table>

            <h3>Lista de produtos</h3>
            <table class=""table table-bordered"">
                <tr>
                    <th>Quantidade</th>
                    <th>Nome</th>
                    <th>Valor</th>
                    <th>TOTAL</th>
                </tr>

");
            EndContext();
#line 71 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                 foreach (var produto in produtos)
                {

#line default
#line hidden
            BeginContext(3227, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(3282, 23, false);
#line 74 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.UnidadesPedidas);

#line default
#line hidden
            EndContext();
            BeginContext(3305, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3341, 12, false);
#line 75 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3389, 27, false);
#line 76 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                       Write(produto.Valor.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3416, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(3453, 55, false);
#line 77 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                        Write((produto.Valor * produto.UnidadesPedidas).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3509, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 79 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                }

#line default
#line hidden
            BeginContext(3562, 113, true);
            WriteLiteral("\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>FRETE</strong></td>\r\n                    <td>");
            EndContext();
            BeginContext(3676, 74, false);
#line 83 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Mascara.ConverterPagarMeIntToDecimal(transacao.Shipping.Fee).ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3750, 141, true);
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\"><strong>TOTAL</strong></td>\r\n                    <td>");
            EndContext();
            BeginContext(3892, 30, false);
#line 87 "C:\Desenvolvimento\Web\S21E18\LojaVirtual\Areas\Cliente\Views\Pedido\Visualizar.cshtml"
                   Write(Model.ValorTotal.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(3922, 219, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </table>\r\n\r\n            <br />\r\n            <br />\r\n            <button class=\"btn btn-outline-primary btn-lg btn-imprimir\">Imprimir</button>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pedido> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:pedido-situacao")]
        public class __Generated__PedidoSituacaoViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__PedidoSituacaoViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public LojaVirtual.Models.Pedido pedido { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("PedidoSituacao", new { pedido });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
