#pragma checksum "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f38fdce9b0ce526cc6d794ab4aa847dbe3b8c1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YeniKitaplar_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f38fdce9b0ce526cc6d794ab4aa847dbe3b8c1f", @"/Views/Shared/Components/YeniKitaplar/Default.cshtml")]
    public class Views_Shared_Components_YeniKitaplar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Kitaplık.Models.Kitaplar>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<table class=\"table table-success table-striped\">\n    <tr>\n        <th>Id</th>\n        <th>Kitap Ad</th>\n        <th>Yazar</th>\n    </tr>\n");
#nullable restore
#line 9 "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\n          <td>");
#nullable restore
#line 12 "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml"
         Write(x.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 13 "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml"
         Write(x.KitapAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n          <td>");
#nullable restore
#line 14 "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml"
         Write(x.Yazar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      </tr> \n");
#nullable restore
#line 16 "/Users/escan/Desktop/Kitaplık/Views/Shared/Components/YeniKitaplar/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Kitaplık.Models.Kitaplar>> Html { get; private set; }
    }
}
#pragma warning restore 1591
