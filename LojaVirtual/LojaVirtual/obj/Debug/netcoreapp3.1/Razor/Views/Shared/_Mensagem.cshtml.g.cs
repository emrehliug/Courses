#pragma checksum "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3871c1d876c3caf2d20786776608ffd3eaecc82c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Mensagem), @"mvc.1.0.view", @"/Views/Shared/_Mensagem.cshtml")]
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
#nullable restore
#line 3 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ViewModels.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.ProdutoAgregador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Models.Contants;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\_ViewImports.cshtml"
using LojaVirtual.Libraries.Texto;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3871c1d876c3caf2d20786776608ffd3eaecc82c", @"/Views/Shared/_Mensagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2cd83e19214e30239a18602a7f0fd276d947335", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Mensagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
 if (ViewData["MSG_E"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">");
#nullable restore
#line 3 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
                             Write(Html.Raw(ViewData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 4 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
 if (TempData["MSG_E"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">");
#nullable restore
#line 7 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
                             Write(Html.Raw(TempData["MSG_E"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 11 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
 if (ViewData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 13 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
                              Write(Html.Raw(ViewData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 14 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
 if (TempData["MSG_S"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-success\">");
#nullable restore
#line 17 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
                              Write(Html.Raw(TempData["MSG_S"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 18 "C:\Users\guigu\Desktop\LojaVirtual\LojaVirtual\Views\Shared\_Mensagem.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
