#pragma checksum "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "962eeb108598c254fe57174a7aca51f8808aac57"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_Results), @"mvc.1.0.view", @"/Views/Search/Results.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Search/Results.cshtml", typeof(AspNetCore.Views_Search_Results))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"962eeb108598c254fe57174a7aca51f8808aac57", @"/Views/Search/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35582cf23656b9dc2fe043caf59fb61cddc2b4f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchResultModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onfocus", new global::Microsoft.AspNetCore.Html.HtmlString("clearThis(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Topic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 153, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row sectionHeader\">\r\n        <div class=\"sectionHeading\">\r\n            <span>Search Results for: ");
            EndContext();
            BeginContext(180, 17, false);
#line 6 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                 Write(Model.SearchQuery);

#line default
#line hidden
            EndContext();
            BeginContext(197, 23, true);
            WriteLiteral("</span>\r\n\r\n            ");
            EndContext();
            BeginContext(220, 450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b951b6b9013e4281b9ef77313fc2567c", async() => {
                BeginContext(284, 65, true);
                WriteLiteral("\r\n                <div class=\"searchForum\">\r\n                    ");
                EndContext();
                BeginContext(349, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c46a2985d50d4c9195dece3a7a890e3f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 10 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(460, 203, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-forumSearch\">\r\n                        <i class=\"material-icons\">search</i>\r\n                    </button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(670, 81, true);
            WriteLiteral("\r\n        </div>\r\n        \r\n    </div>\r\n    <div class=\"row forumIndexContent\">\r\n");
            EndContext();
#line 20 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
         if (!Model.EmptySearchQuery)
        {

#line default
#line hidden
            BeginContext(801, 108, true);
            WriteLiteral("            <table class=\"table table-hover table-bordered\" id=\"forumIndexTable\">\r\n                <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                     foreach (var post in Model.Posts)
                    {

#line default
#line hidden
            BeginContext(988, 221, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"postData\">\r\n                                    <div class=\"postTitle\">\r\n                                        ");
            EndContext();
            BeginContext(1209, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91196b6dcb0c43af832c577e3979f3b7", async() => {
                BeginContext(1282, 10, false);
#line 30 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                                                                           Write(post.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                                                          WriteLiteral(post.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-postId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["postId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1296, 326, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""forumSubTitle"">
                                        <div>
                                            by:
                                            <span class=""postAuthor"">
                                                ");
            EndContext();
            BeginContext(1622, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a7d4cdd762f41ed9199f9a41be56d43", async() => {
                BeginContext(1706, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(1761, 15, false);
#line 37 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                               Write(post.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(1776, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-authorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                                                                        WriteLiteral(post.AuthorId);

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
            BeginContext(1830, 51, true);
            WriteLiteral("\r\n                                                (");
            EndContext();
            BeginContext(1882, 17, false);
#line 39 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                            Write(post.AuthorRating);

#line default
#line hidden
            EndContext();
            BeginContext(1899, 223, true);
            WriteLiteral(")\r\n                                            </span>\r\n                                            in:\r\n                                            <span class=\"postForum\">\r\n                                                ");
            EndContext();
            BeginContext(2122, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e617b1b2a31a4c5790968a6c05607c1b", async() => {
                BeginContext(2203, 15, false);
#line 43 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                                                                                           Write(post.Forum.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-forumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                                                                    WriteLiteral(post.Forum.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-forumId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["forumId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2222, 409, true);
            WriteLiteral(@"
                                            </span>
                                            
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class=""forumPostCount"">
                                    Replies: ");
            EndContext();
            BeginContext(2632, 17, false);
#line 52 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                        Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 165, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"postDate\">");
            EndContext();
            BeginContext(2815, 15, false);
#line 56 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                                 Write(post.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(2830, 74, true);
            WriteLiteral("</div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                    }

#line default
#line hidden
            BeginContext(2927, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3011, 167, true);
            WriteLiteral("            <div class=\"noPosts\">\r\n                <i class=\"material-icons md-72\">qustion_answer</i>\r\n                <h3>\r\n                    No serach results for ");
            EndContext();
            BeginContext(3179, 17, false);
#line 68 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
                                     Write(Model.SearchQuery);

#line default
#line hidden
            EndContext();
            BeginContext(3196, 52, true);
            WriteLiteral(" <br />\r\n                </h3>\r\n            </div>\r\n");
            EndContext();
#line 71 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Search\Results.cshtml"
        }

#line default
#line hidden
            BeginContext(3259, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3296, 112, true);
                WriteLiteral("\r\n    <script>\r\n        function clearThis(target) {\r\n            target.value = \"\";\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(3411, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchResultModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
