#pragma checksum "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cb4299bb0d17df50243915abfc6b822b7b1807d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ProductSummary.cshtml", typeof(AspNetCore.Views_Shared_ProductSummary))]
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
#line 1 "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models;

#line default
#line hidden
#line 2 "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\_ViewImports.cshtml"
using SportsStore.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cb4299bb0d17df50243915abfc6b822b7b1807d", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d02e1652a955861aa4ebf44ba769d870b1c8b28", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 101, true);
            WriteLiteral("\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n    <h4>\r\n        ");
            EndContext();
            BeginContext(118, 10, false);
#line 6 "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
   Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(128, 96, true);
            WriteLiteral("\r\n        <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n            <small>");
            EndContext();
            BeginContext(225, 25, false);
#line 8 "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
              Write(Model.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(250, 81, true);
            WriteLiteral("</small>\r\n        </span>\r\n    </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">");
            EndContext();
            BeginContext(332, 17, false);
#line 12 "C:\Users\Matt\source\repos\SportsStore\SportsStore\Views\Shared\ProductSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(349, 18, true);
            WriteLiteral("</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
