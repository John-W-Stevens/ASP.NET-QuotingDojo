#pragma checksum "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "128ecfa4c06e46c074dfbcbb7aab40aabcdff61a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayQuotes), @"mvc.1.0.view", @"/Views/Home/DisplayQuotes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayQuotes.cshtml", typeof(AspNetCore.Views_Home_DisplayQuotes))]
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
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo;

#line default
#line hidden
#line 2 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/_ViewImports.cshtml"
using QuotingDojo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"128ecfa4c06e46c074dfbcbb7aab40aabcdff61a", @"/Views/Home/DisplayQuotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1590bf4c09dff90063a94a6cfc81488d471e1d42", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayQuotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 248, true);
            WriteLiteral("\r\n<div class=\"row\" id=\"header-row2\">\r\n    <div class=\"col-12 text-center\">\r\n        <h2>Here are the awesome quotes!</h2>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\" id=\"quote-row\">\r\n\r\n   <div class=\"col-12 col-md-8 offset-md-2 col-lg-6 offset-lg-3\">\r\n");
            EndContext();
#line 14 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
        foreach (var Q in ViewBag.Quotes)
       {

#line default
#line hidden
            BeginContext(346, 19, true);
            WriteLiteral("               <p>\"");
            EndContext();
            BeginContext(366, 10, false);
#line 16 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
              Write(Q["quote"]);

#line default
#line hidden
            EndContext();
            BeginContext(376, 47, true);
            WriteLiteral("\"</p>\r\n               <p class=\"text-center\">- ");
            EndContext();
            BeginContext(424, 13, false);
#line 17 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
                                   Write(Q["username"]);

#line default
#line hidden
            EndContext();
            BeginContext(437, 4, true);
            WriteLiteral(" at ");
            EndContext();
            BeginContext(442, 15, false);
#line 17 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
                                                     Write(Q["created_at"]);

#line default
#line hidden
            EndContext();
            BeginContext(457, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 18 "/Users/johnstevens/coding_dojo/dotnet/asp_mvc_1/QuotingDojo/Views/Home/DisplayQuotes.cshtml"
       }

#line default
#line hidden
            BeginContext(473, 23, true);
            WriteLiteral("   </div>\r\n\r\n\r\n\r\n</div>");
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