#pragma checksum "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a1aa0f1aea879acb9c527d5ea1068ebdd772ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forum_Topic), @"mvc.1.0.view", @"/Views/Forum/Topic.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forum/Topic.cshtml", typeof(AspNetCore.Views_Forum_Topic))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a1aa0f1aea879acb9c527d5ea1068ebdd772ae", @"/Views/Forum/Topic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c51b701450980a2f4ff0acf20eb0092e11533a", @"/Views/_ViewImports.cshtml")]
    public class Views_Forum_Topic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ForumTopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-newPost"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchBar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Search..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onfocus", new global::Microsoft.AspNetCore.Html.HtmlString("clearThis(this)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "forumId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Forum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 133, true);
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row sectionHeader\">\r\n        <div class=\"sectionHeading\">\r\n            <span>");
            EndContext();
            BeginContext(158, 16, false);
#line 6 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
             Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(174, 15, true);
            WriteLiteral(" Forum</span>\r\n");
            EndContext();
#line 7 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(253, 60, true);
            WriteLiteral("                <span id=\"headingBtn\">\r\n                    ");
            EndContext();
            BeginContext(313, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "904f4001e86442ea8348999e7d8654b8", async() => {
                BeginContext(418, 11, true);
                WriteLiteral("Create Post");
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
#line 10 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                                                        WriteLiteral(Model.Forum.Id);

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
            BeginContext(433, 27, true);
            WriteLiteral("\r\n                </span>\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
            }

#line default
#line hidden
            BeginContext(475, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(487, 517, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a1848c7647f48f69c149c1a5a2cb524", async() => {
                BeginContext(550, 65, true);
                WriteLiteral("\r\n                <div class=\"searchForum\">\r\n                    ");
                EndContext();
                BeginContext(615, 111, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "adef67ebd13d42f08e7864516242c4db", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 15 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchQuery);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(726, 207, true);
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-forumSearch\">\r\n                        <i class=\"material-icons\">search</i>\r\n                    </button>\r\n                </div>\r\n                ");
                EndContext();
                BeginContext(933, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f8df04d53b184023b7215cbf1549ca25", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 20 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Forum.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(983, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1004, 94, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"sectionDescription\">\r\n            <div class=\"forumLogo\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1098, "\"", 1149, 3);
            WriteAttributeValue("", 1106, "background-image:url(", 1106, 21, true);
#line 24 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
WriteAttributeValue("", 1127, Model.Forum.ImageUrl, 1127, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 1148, ")", 1148, 1, true);
            EndWriteAttribute();
            BeginContext(1150, 39, true);
            WriteLiteral("></div>\r\n            <p>Welcome to the ");
            EndContext();
            BeginContext(1190, 16, false);
#line 25 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                         Write(Model.Forum.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 53, true);
            WriteLiteral(" forum, Please keep posts friendly and on topic</p>\r\n");
            EndContext();
#line 26 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
             if (!User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(1324, 112, true);
            WriteLiteral("                <p>\r\n                    <span>\r\n                        You must be a\r\n                        ");
            EndContext();
            BeginContext(1436, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b6fe0ce6ae7463c952c50e4e090123d", async() => {
                BeginContext(1486, 73, true);
                WriteLiteral("\r\n                            registered member\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1563, 99, true);
            WriteLiteral("\r\n                        to create a new post\r\n                    </span>\r\n                </p>\r\n");
            EndContext();
#line 37 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
            }

#line default
#line hidden
            BeginContext(1677, 69, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"row forumIndexContent\">\r\n");
            EndContext();
#line 41 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
         if (Model.Posts.Any())
        {

#line default
#line hidden
            BeginContext(1790, 108, true);
            WriteLiteral("            <table class=\"table table-hover table-bordered\" id=\"forumIndexTable\">\r\n                <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                     foreach (var post in Model.Posts)
                    {

#line default
#line hidden
            BeginContext(1977, 221, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <div class=\"postData\">\r\n                                    <div class=\"postTitle\">\r\n                                        ");
            EndContext();
            BeginContext(2198, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04e4359225649cca2df73f0845c2be2", async() => {
                BeginContext(2271, 10, false);
#line 51 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                                                                                           Write(post.Title);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-postId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 51 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
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
            BeginContext(2285, 277, true);
            WriteLiteral(@"
                                    </div>
                                    <div class=""forumSubTitle"">
                                        <div>
                                            <span class=""postAuthor"">
                                                ");
            EndContext();
            BeginContext(2562, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "acc6c3c8e3f54dd5aeeac152ff911953", async() => {
                BeginContext(2646, 54, true);
                WriteLiteral("\r\n                                                    ");
                EndContext();
                BeginContext(2701, 15, false);
#line 57 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                               Write(post.AuthorName);

#line default
#line hidden
                EndContext();
                BeginContext(2716, 50, true);
                WriteLiteral("\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_15.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_15);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-authorId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
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
            BeginContext(2770, 100, true);
            WriteLiteral("\r\n                                            </span>\r\n                                            (");
            EndContext();
            BeginContext(2871, 17, false);
#line 60 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                        Write(post.AuthorRating);

#line default
#line hidden
            EndContext();
            BeginContext(2888, 73, true);
            WriteLiteral(") on\r\n                                            <span class=\"postDate\">");
            EndContext();
            BeginContext(2962, 15, false);
#line 61 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                                              Write(post.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(2977, 317, true);
            WriteLiteral(@"</span>
                                        </div>
                                    </div>
                                </div>
                            </td>
                            <td>
                                <div class=""forumPostCount"">
                                    Replies: ");
            EndContext();
            BeginContext(3295, 17, false);
#line 68 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                        Write(post.RepliesCount);

#line default
#line hidden
            EndContext();
            BeginContext(3312, 165, true);
            WriteLiteral("\r\n                                </div>\r\n                            </td>\r\n                            <td>\r\n                                <div class=\"postDate\">");
            EndContext();
            BeginContext(3478, 15, false);
#line 72 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                                 Write(post.DatePosted);

#line default
#line hidden
            EndContext();
            BeginContext(3493, 74, true);
            WriteLiteral("</div>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 75 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                    }

#line default
#line hidden
            BeginContext(3590, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 78 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(3674, 241, true);
            WriteLiteral("            <div class=\"noPosts\">\r\n                <i class=\"material-icons md-72\">qustion_answer</i>\r\n                <h3>\r\n                    It looks like there are no posts to be found.\r\n                    Why not\r\n                    ");
            EndContext();
            BeginContext(3915, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2c2f8abc3f9453c91fbe0675aac3882", async() => {
                BeginContext(3996, 65, true);
                WriteLiteral("\r\n                        <span>Post</span>\r\n                    ");
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
#line 86 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
                                                                        WriteLiteral(Model.Forum.Id);

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
            BeginContext(4065, 76, true);
            WriteLiteral("\r\n                    Something\r\n                </h3>\r\n            </div>\r\n");
            EndContext();
#line 92 "C:\Users\User\Desktop\repos\ForumNineNIne\ForumNineNine\ForumNineNine\Views\Forum\Topic.cshtml"
        }

#line default
#line hidden
            BeginContext(4152, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4189, 112, true);
                WriteLiteral("\r\n    <script>\r\n        function clearThis(target) {\r\n            target.value = \"\";\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4304, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForumTopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
