#pragma checksum "/Users/douglasherman/Desktop/CodingDojo/C#/LoginRegC#/Views/Home/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aec83bb05a17e772ecc7bc1f924ff8c08ac2c7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
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
#line 1 "/Users/douglasherman/Desktop/CodingDojo/C#/LoginRegC#/Views/_ViewImports.cshtml"
using LoginRegC_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/douglasherman/Desktop/CodingDojo/C#/LoginRegC#/Views/_ViewImports.cshtml"
using LoginRegC_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aec83bb05a17e772ecc7bc1f924ff8c08ac2c7f", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd137a3500a5da18b0db2dca5339b9140e01f6eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Welcome, ");
#nullable restore
#line 1 "/Users/douglasherman/Desktop/CodingDojo/C#/LoginRegC#/Views/Home/Success.cshtml"
        Write(ViewBag.User.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\n\n<a class=\"btn btn-lg\" style=\"background-color: pink; color: white;\" href=\"logout\">Logout</a>\n\n");
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
