#pragma checksum "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99a4bc1288f710bb8c37f0dda2a0ae9c8fa9c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Index), @"mvc.1.0.view", @"/Views/Forum/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Index.cshtml", typeof(AspNetCore.Views_Forum_Index))]
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
#line 1 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.Models.ForumViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d99a4bc1288f710bb8c37f0dda2a0ae9c8fa9c24", @"/Views/Forum/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8eb537a893671c19d16c8ebdd78233b2deeb64b", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumIndexModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 88, true);
            WriteLiteral("\r\n<h1>Forums</h1>\r\n<table class=\"table table-hover\" id=\"forumIndexTable\">\r\n    <tbody>\r\n");
            EndContext();
#line 6 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Index.cshtml"
         foreach (var forum in Model.ForumList)
        {

#line default
#line hidden
            BeginContext(172, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(211, 10, false);
#line 9 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Index.cshtml"
               Write(forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(221, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(249, 17, false);
#line 10 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Index.cshtml"
               Write(forum.Description);

#line default
#line hidden
            EndContext();
            BeginContext(266, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(303, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
