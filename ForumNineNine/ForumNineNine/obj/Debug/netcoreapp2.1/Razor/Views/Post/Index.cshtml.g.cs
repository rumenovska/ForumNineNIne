#pragma checksum "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b76f25892c92c3f49620e2481d50a8b8356c434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Index), @"mvc.1.0.view", @"/Views/Post/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/Index.cshtml", typeof(AspNetCore.Views_Post_Index))]
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
#line 4 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.Models.PostViewModels;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.WebModels.AccountViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b76f25892c92c3f49620e2481d50a8b8356c434", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c51b701450980a2f4ff0acf20eb0092e11533a", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newReply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 168, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row postHeader\">\r\n        <div class=\"postHeading\">\r\n            <span class=\"postIndexTitle\">\r\n                ");
            EndContext();
            BeginContext(192, 11, false);
#line 7 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(203, 58, true);
            WriteLiteral("\r\n            </span>\r\n            <span id=\"headingBtn\"> ");
            EndContext();
            BeginContext(261, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87cf942f5e584a45a5f5c4c63dd54d28", async() => {
                BeginContext(362, 8, true);
                WriteLiteral("Back to ");
                EndContext();
                BeginContext(371, 15, false);
#line 9 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                                                                                           Write(Model.ForumName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-forumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                                       WriteLiteral(Model.ForumId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-forumId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(390, 176, true);
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"row\" id=\"postIndexContent\">\r\n        <div class=\"col-md-3 postAuthorContainer\">\r\n            <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 566, "\"", 618, 3);
            WriteAttributeValue("", 574, "background-image:url(", 574, 21, true);
#line 15 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
WriteAttributeValue("", 595, Model.AuthorImageUrl, 595, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 616, ");", 616, 2, true);
            EndWriteAttribute();
            BeginContext(619, 21, true);
            WriteLiteral("></div>\r\n            ");
            EndContext();
            BeginContext(640, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b0f793109114b80ae413428c0036271", async() => {
                BeginContext(724, 16, false);
#line 16 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                                          Write(Model.AuthorName);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                  WriteLiteral(Model.AuthorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(744, 37, true);
            WriteLiteral("\r\n            <span class=\"postDate\">");
            EndContext();
            BeginContext(782, 13, false);
#line 17 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                              Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(795, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 18 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
             if (Model.IsAuthorAdmin)
            {

#line default
#line hidden
            BeginContext(858, 60, true);
            WriteLiteral("                <span class=\"isAdmin smaller\">Admin</span>\r\n");
            EndContext();
#line 21 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(933, 120, true);
            WriteLiteral("            <div class=\"col-md-9 postContentContainer\">\r\n                <div class=\"postContent\">\r\n                    ");
            EndContext();
            BeginContext(1054, 27, false);
#line 24 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
               Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1081, 123, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"row\" id=\"replyDivider\"></div>\r\n");
            EndContext();
#line 31 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(1252, 45, true);
            WriteLiteral("        <div class=\"row\">\r\n            <span>");
            EndContext();
            BeginContext(1297, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "616702add83b4926a8175fb9e8b13ba3", async() => {
                BeginContext(1397, 10, true);
                WriteLiteral("Post Reply");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1411, 25, true);
            WriteLiteral("</span>\r\n        </div>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1443, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 37 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
     if (Model.Replies.Any())
    {
        foreach (var reply in Model.Replies)
        {

#line default
#line hidden
            BeginContext(1538, 153, true);
            WriteLiteral("            <div class=\"row replyContent\">\r\n                <div class=\"col-md-3 replyAuthorContainer\">\r\n                    <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1691, "\"", 1742, 3);
            WriteAttributeValue("", 1699, "background-image:url(", 1699, 21, true);
#line 43 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
WriteAttributeValue("", 1720, reply.AuthorImageUrl, 1720, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1741, ")", 1741, 1, true);
            EndWriteAttribute();
            BeginContext(1743, 29, true);
            WriteLiteral("></div>\r\n                    ");
            EndContext();
            BeginContext(1772, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9147e4a4cd104d1fa506f43cafe95f8a", async() => {
                BeginContext(1857, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1884, 16, false);
#line 45 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                   Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(1900, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-authorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                            WriteLiteral(reply.AuthorId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["authorId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-authorId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["authorId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1926, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 47 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                     if (reply.IsAuthorAdmin)
                    {

#line default
#line hidden
            BeginContext(1998, 98, true);
            WriteLiteral("                        <div class=\"isAdmin smaller\">Admin</div>\r\n                        <br />\r\n");
            EndContext();
#line 51 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2119, 26, true);
            WriteLiteral("                    <span>");
            EndContext();
            BeginContext(2146, 13, false);
#line 52 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                     Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2159, 166, true);
            WriteLiteral("</span>\r\n                </div>\r\n                <div class=\"col-md-9 replyContentContainer\">\r\n                    <div class=\"postContent\">\r\n                        ");
            EndContext();
            BeginContext(2326, 28, false);
#line 56 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                   Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(2354, 74, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 60 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2463, 142, true);
            WriteLiteral("        <div class=\"noPosts\">\r\n            <h3>\r\n                There are no replies to this post <br />\r\n            </h3>\r\n        </div>\r\n");
            EndContext();
#line 69 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2612, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
