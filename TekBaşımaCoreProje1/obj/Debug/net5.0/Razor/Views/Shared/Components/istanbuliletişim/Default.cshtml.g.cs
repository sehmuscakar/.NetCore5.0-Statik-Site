#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\Shared\Components\istanbuliletişim\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f2f40a0036b45285e932d16001ca9f007de9020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_istanbuliletişim_Default), @"mvc.1.0.view", @"/Views/Shared/Components/istanbuliletişim/Default.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\_ViewImports.cshtml"
using TekBaşımaCoreProje1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\_ViewImports.cshtml"
using TekBaşımaCoreProje1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f2f40a0036b45285e932d16001ca9f007de9020", @"/Views/Shared/Components/istanbuliletişim/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938bd1259211e1d5fc7b74fc9ce1a83a5d4b56d6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_istanbuliletişim_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Yeni>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"    <div class=""row text-lg-center"">
        <div class=""col-6 text-center"">
        <div class=""text-center"">

            <h3 class=""accordion-header""> İstanbul İletişim </h3>
            <table class="" table table-hover table-bordered"">
                
                <tr>
                    <th>Telefon</th>
                    <th>Mail Adresi</th>
                </tr>

");
#nullable restore
#line 14 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\Shared\Components\istanbuliletişim\Default.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                          ");
#nullable restore
#line 18 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\Shared\Components\istanbuliletişim\Default.cshtml"
                     Write(item.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      \r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 22 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\Shared\Components\istanbuliletişim\Default.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 25 "C:\Users\Şehmus\Desktop\Dosyalar\Yavuz .net Core\TekBaşımaCoreProje1\TekBaşımaCoreProje1\Views\Shared\Components\istanbuliletişim\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Yeni>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
