#pragma checksum "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "155fedae1831030a4f8fca7b866d8ab01ff8a72b8f99cd42bedca14d4a05e2f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Components_Yorumlar_Default), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Components/Yorumlar/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\_ViewImports.cshtml"
using CafeApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\_ViewImports.cshtml"
using CafeApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"155fedae1831030a4f8fca7b866d8ab01ff8a72b8f99cd42bedca14d4a05e2f3", @"/Areas/Customer/Views/Home/Components/Yorumlar/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"0d987a2ea6e0670505fb2ae123c7b48b3c3455183aa5569831650f7eb2072499", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Customer_Views_Home_Components_Yorumlar_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CafeApp.Models.Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"blo4 p-b-63\">\r\n        <!-- - -->\r\n        <div class=\"pic-blo4 hov-img-zoom bo-rad-10 pos-relative\">\r\n            <a>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 232, "\"", 249, 1);
#nullable restore
#line 9 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
WriteAttributeValue("", 238, item.Image, 238, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"IMG-BLOG\">\r\n            </a>\r\n\r\n            <div class=\"date-blo4 flex-col-c-m\">\r\n                <span class=\"txt30 m-b-4\">\r\n                    ");
#nullable restore
#line 14 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
               Write(item.Tarih.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n\r\n                <span class=\"txt31\">\r\n                    ");
#nullable restore
#line 18 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
               Write(item.Tarih.ToString("MMMM ,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n\r\n        <!-- - -->\r\n        <div class=\"text-blo4 p-t-33\">\r\n            <h4 class=\"p-b-16\">\r\n                <a class=\"tit9\">");
#nullable restore
#line 26 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h4>\r\n\r\n            <div class=\"txt32 flex-w p-b-24\">\r\n                <span>\r\n                    ");
#nullable restore
#line 31 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"m-r-6 m-l-4\">|</span>\r\n                </span>\r\n\r\n                <span>\r\n                    ");
#nullable restore
#line 36 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
               Write(item.Tarih.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span class=\"m-r-6 m-l-4\">|</span>\r\n                </span>\r\n\r\n\r\n\r\n\r\n            </div>\r\n\r\n            <p>\r\n                ");
#nullable restore
#line 46 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"
           Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 50 "C:\Users\admin\Desktop\kod dosyaları\cafe uygulaması programlama 2 dersi\ESKİ\CafeApp.WebUI\CafeApp\Areas\Customer\Views\Home\Components\Yorumlar\Default.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CafeApp.Models.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
