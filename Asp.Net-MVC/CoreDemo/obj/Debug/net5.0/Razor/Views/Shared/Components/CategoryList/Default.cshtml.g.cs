#pragma checksum "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f823a1aa75838075da695666197cec9ebc39ee5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f823a1aa75838075da695666197cec9ebc39ee5d", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t<h4>Kategoriler</h4>\r\n\t\t\t\t\t\t\t<ul class=\"list-group single\">\r\n");
#nullable restore
#line 5 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
                                 foreach(var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<li class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 7 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
                               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t<span class=\"badge badge-primary badge-pill\">14</span>\r\n\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 10 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Shared\Components\CategoryList\Default.cshtml"
								
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
