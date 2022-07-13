#pragma checksum "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ddd0d2c7e80e882933467d56ce0192f213c850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\_ViewImports.cshtml"
using ManyToManyTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ddd0d2c7e80e882933467d56ce0192f213c850", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86f65a1aa4a570b3812842d134ccc356133d736f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Book>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 8 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
     foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li> BookName ");
#nullable restore
#line 10 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"

        foreach (var bookAuthor in item.BookAuthors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span> ");
#nullable restore
#line 14 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
              Write(bookAuthor.Author.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> \n            <span>");
#nullable restore
#line 15 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
             Write(bookAuthor.Author.SocialAccount.Instagram);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\n");
#nullable restore
#line 16 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
        }
        foreach (var image in item.Images)
        {
            if (image.IsMain)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>");
#nullable restore
#line 21 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
                 Write(image.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n");
#nullable restore
#line 22 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
            }
        }
        foreach (var g in item.BookGenres)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <span>");
#nullable restore
#line 26 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
           Write(g.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>  \n");
#nullable restore
#line 27 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 29 "D:\Asp.NetCore\ManyToManyTask\ManyToManyTask\Views\Home\Index.cshtml"
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Book>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
