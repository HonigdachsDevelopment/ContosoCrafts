#pragma checksum "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936c7693db397a2e664468527fc80bf33f718a57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ContosoCrafts.WebSite.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ContosoCrafts.WebSite.Pages
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
#line 1 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\_ViewImports.cshtml"
using ContosoCrafts.WebSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936c7693db397a2e664468527fc80bf33f718a57", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa11e68d0151211d8b40704a22e8c4f2f2022cc3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- web content display upper the directive to declare as diplayable content page, the related c# Model and the Name of the page-->
<div class=""container-fluid"">

    <div class=""text-center"">
        <h4 class=""display-4"">START BLINKING</h4>
        <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    </div>
    <div class=""card-columns"" style=""display: inline-block"">

");
#nullable restore
#line 16 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\" id=\"products\">\r\n                <div class=\"card-img\"");
            BeginWriteAttribute("style", " style=\"", 659, "\"", 708, 5);
            WriteAttributeValue("", 667, "background-image:", 667, 17, true);
            WriteAttributeValue(" ", 684, "url(\'", 685, 6, true);
#nullable restore
#line 19 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
WriteAttributeValue("", 690, product.Image, 690, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 704, "\');", 704, 3, true);
            WriteAttributeValue(" ", 707, "", 708, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"> ");
#nullable restore
#line 21 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
                                       Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</h5>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
                                    Write(product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <h2>\r\n            </h2>\r\n");
#nullable restore
#line 27 "C:\Daten\ASP101\ContosoCrafts\ContosoCrafts.WebSite\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
