#pragma checksum "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "ac91678999ba14a609f9d7f8f304e1d8a5d3241f79eb26f13319b130daa9e292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\_ViewImports.cshtml"
using Homework1

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\_ViewImports.cshtml"
using Homework1.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"ac91678999ba14a609f9d7f8f304e1d8a5d3241f79eb26f13319b130daa9e292", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b5d03c00fbf18caefb88307bf9790394ad40dd3bbb940862997f6faa1ae5ed77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Homework1.ViewModels.DatasViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"background-color:darkgray\">\r\n    <h1>Drinks</h1>\r\n    <ul>\r\n");
#nullable restore
#line 6 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
         foreach (var item in Model.Drinks)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <li>Name : ");
            Write(
#nullable restore
#line 8 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                        item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <li>Description : ");
            Write(
#nullable restore
#line 9 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                               item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <hr />\r\n            <br />\r\n");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </ul>\r\n    <hr />\r\n    <h1>Hot Meals</h1>\r\n    <ul>\r\n");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
         foreach (var item in Model.HotMeals)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <li>Name : ");
            Write(
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                        item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <li>Description : ");
            Write(
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                               item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <hr />\r\n            <br />\r\n");
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </ul>\r\n    <h1>Fast Foods</h1>\r\n    <ul>\r\n");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
         foreach (var item in Model.FastFoods)
        {

#line default
#line hidden
#nullable disable

            WriteLiteral("            <li>Name : ");
            Write(
#nullable restore
#line 29 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                        item.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <li>Description : ");
            Write(
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
                               item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</li>\r\n            <hr />\r\n            <br />\r\n");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Homework1.ViewModels.DatasViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
