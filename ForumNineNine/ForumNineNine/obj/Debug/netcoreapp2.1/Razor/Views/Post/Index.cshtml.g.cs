#pragma checksum "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b703cef007ce6059d4f96f574184c08f85e1c2"
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
#line 6 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.Models.SearchViewModels;

#line default
#line hidden
#line 7 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 8 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\_ViewImports.cshtml"
using ForumNineNine.Models.ReplyViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b703cef007ce6059d4f96f574184c08f85e1c2", @"/Views/Post/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62b54eb8fc5d6fee3ce2632fb3e52b3244591f17", @"/Views/_ViewImports.cshtml")]
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
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(23, 188, true);
            WriteLiteral("\r\n    <div class=\"container body-content\">\r\n        <div class=\"row postHeader\">\r\n            <div class=\"postHeading\">\r\n                <span class=\"postIndexTitle\">\r\n                    ");
            EndContext();
            BeginContext(212, 11, false);
#line 7 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(223, 66, true);
            WriteLiteral("\r\n                </span>\r\n                <span id=\"headingBtn\"> ");
            EndContext();
            BeginContext(289, 129, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35c71151ee494d96a215eae25c747374", async() => {
                BeginContext(390, 8, true);
                WriteLiteral("Back to ");
                EndContext();
                BeginContext(399, 15, false);
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
            BeginContext(418, 196, true);
            WriteLiteral("</span>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\" id=\"postIndexContent\">\r\n            <div class=\"col-md-3 postAuthorContainer\">\r\n                <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 614, "\"", 666, 3);
            WriteAttributeValue("", 622, "background-image:url(", 622, 21, true);
#line 15 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
WriteAttributeValue("", 643, Model.AuthorImageUrl, 643, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 664, ");", 664, 2, true);
            EndWriteAttribute();
            BeginContext(667, 25, true);
            WriteLiteral("></div>\r\n                ");
            EndContext();
            BeginContext(692, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01fa5d5ed4734d74bb2b5f2fb62914a9", async() => {
                BeginContext(776, 16, false);
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
            BeginContext(796, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 18 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                 if (Model.IsAuthorAdmin)
                {

#line default
#line hidden
            BeginContext(862, 64, true);
            WriteLiteral("                    <span class=\"isAdmin smaller\">Admin</span>\r\n");
            EndContext();
#line 21 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(945, 40, true);
            WriteLiteral("\r\n                <div class=\"postDate\">");
            EndContext();
            BeginContext(986, 13, false);
#line 23 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                 Write(Model.Created);

#line default
#line hidden
            EndContext();
            BeginContext(999, 148, true);
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"col-md-9 postContentContainer\">\r\n                <div class=\"postContent\">\r\n                    ");
            EndContext();
            BeginContext(1148, 27, false);
#line 27 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
               Write(Html.Raw(Model.PostContent));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 113, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\" id=\"replyDivider\"></div>\r\n");
            EndContext();
#line 32 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
         if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(1344, 71, true);
            WriteLiteral("            <div class=\"row\" id=\"postReplyRow\">\r\n                <span>");
            EndContext();
            BeginContext(1415, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ebc28e97b2f4469cb18a3dcff0f42148", async() => {
                BeginContext(1515, 10, true);
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
#line 35 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
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
            BeginContext(1529, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
#line 37 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1594, 71, true);
            WriteLiteral("            <div class=\"row\" id=\"postReplyRow\">\r\n                <span>");
            EndContext();
            BeginContext(1665, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ba97b55506b4d0a9b830629728b16cc", async() => {
                BeginContext(1737, 14, true);
                WriteLiteral("Login to Reply");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1755, 29, true);
            WriteLiteral("</span>\r\n            </div>\r\n");
            EndContext();
#line 43 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1795, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 44 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
         if (Model.Replies.Any())
        {
            foreach (var reply in Model.Replies)
            {

#line default
#line hidden
            BeginContext(1906, 165, true);
            WriteLiteral("                <div class=\"row replyContent\">\r\n                    <div class=\"col-md-2 replyAuthorContainer\">\r\n                        <div class=\"postAuthorImage\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2071, "\"", 2122, 3);
            WriteAttributeValue("", 2079, "background-image:url(", 2079, 21, true);
#line 50 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
WriteAttributeValue("", 2100, reply.AuthorImageUrl, 2100, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 2121, ")", 2121, 1, true);
            EndWriteAttribute();
            BeginContext(2123, 33, true);
            WriteLiteral("></div>\r\n                        ");
            EndContext();
            BeginContext(2156, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69f94e21052f43c594521d2a96d308e6", async() => {
                BeginContext(2239, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2270, 16, false);
#line 52 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                       Write(reply.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2286, 26, true);
                WriteLiteral("\r\n                        ");
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
#line 51 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                                                              WriteLiteral(reply.AuthorId);

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
            BeginContext(2316, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                         if (reply.IsAuthorAdmin)
                        {

#line default
#line hidden
            BeginContext(2396, 106, true);
            WriteLiteral("                            <div class=\"isAdmin smaller\">Admin</div>\r\n                            <br />\r\n");
            EndContext();
#line 58 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2529, 46, true);
            WriteLiteral("                        <div class=\"postDate\">");
            EndContext();
            BeginContext(2576, 13, false);
#line 59 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                                         Write(reply.Created);

#line default
#line hidden
            EndContext();
            BeginContext(2589, 182, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-md-10 replyContentContainer\">\r\n                        <div class=\"postContent\">\r\n                            ");
            EndContext();
            BeginContext(2772, 28, false);
#line 63 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
                       Write(Html.Raw(reply.ReplyContent));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 86, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 67 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(2937, 162, true);
            WriteLiteral("            <div class=\"noPosts\">\r\n                <h3>\r\n                    There are no replies to this post <br />\r\n                </h3>\r\n            </div>\r\n");
            EndContext();
#line 76 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Post\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3110, 16, true);
            WriteLiteral("    </div>\r\n\r\n\r\n");
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
