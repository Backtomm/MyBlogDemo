#pragma checksum "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2ee2202f74623fd89fdd208c509db1cbaeb4c54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Show), @"mvc.1.0.view", @"/Views/Blog/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Show.cshtml", typeof(AspNetCore.Views_Blog_Show))]
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
#line 1 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\_ViewImports.cshtml"
using My.Blog.Web;

#line default
#line hidden
#line 2 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\_ViewImports.cshtml"
using My.Blog.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2ee2202f74623fd89fdd208c509db1cbaeb4c54", @"/Views/Blog/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5704508a772bae6ad83ac289d99ae0a7d87a6131", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<My.Blog.Model.Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("article-tag-list-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Tag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tag", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Hexo/css/fancybox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Hexo/js/highlight.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Hexo/js/r.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/Hexo/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(54, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(79, 442, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82981bbfb90145dd996310ea91f2e4a6", async() => {
                BeginContext(85, 100, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <title>");
                EndContext();
                BeginContext(186, 11, false);
#line 10 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
      Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(197, 317, true);
                WriteLiteral(@" - 我的博客</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <link href=""/assets/Hexo/css/style.css"" rel=""stylesheet"" />
    <link href=""/assets/Default/styles/font-awesome.css"" rel=""stylesheet"" />
    <script src=""/assets/Hexo/js/jquery-1.10.2.min.js""></script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(521, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(525, 4307, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad7862ec03143b0b96311aa44e893cf", async() => {
                BeginContext(531, 2272, true);
                WriteLiteral(@"
    
    <div id=""container"">
        <div class=""mid-col"">
            <nav id=""mobile-nav"">
                <div class=""overlay"">
                    <h1 class=""header-author js-mobile-header hide"">站点名称</h1>
                </div>
                <div class=""intrude-less"">
                    <header id=""header"" class=""inner"">
                        <div class=""profilepic"">
                            <img src=""http://7vzqh7.com1.z0.glb.clouddn.com/avatar.jpg"" class=""js-avatar"">
                        </div>
                        <hgroup>
                            <h1 class=""header-author"">站点名称</h1>
                        </hgroup>

                        <p class=""header-subtitle"">站点描述</p>

                        <nav class=""header-menu"">
                            <ul>
                                <li><a href=""/"">主页</a></li>

                                <li><a href=""/catalog/"">分类一 （1）</a></li>
                                <li><a href=""/catalog/"">分类一 （1）</a></li");
                WriteLiteral(@">
                                <li><a href=""/catalog/"">分类一 （1）</a></li>
                                <li><a href=""/catalog/"">分类一 （1）</a></li>

                                <div class=""clearfix""></div>
                            </ul>
                        </nav>
                        <nav class=""header-nav"">
                            <div class=""social"">
                                <a class=""github"" target=""_blank"" href=""https://github.com/xiaotian000"" title=""github"">github</a>
                                <a class=""linkedin"" target=""_blank"" href=""http://www.linkedin.com/in/%E7%A7%8B%E5%AE%9E-%E7%94%B0-146850126"" title=""LinkedIn"">LinkedIn</a>
                                <a class=""mail"" target=""_blank"" href=""mailto:1756768668@qq.com"" title=""Email"">Email</a>
                            </div>
                        </nav>
                    </header>
                </div>
            </nav>
            <div class=""body-wrap"">
                <article class=""articl");
                WriteLiteral("e article-type-post\" itemscope itemprop=\"blogPost\">\r\n                    <div class=\"article-meta\">\r\n                        <a href=\"/post/\" class=\"article-date\">\r\n                            <time itemprop=\"datePublished\">");
                EndContext();
                BeginContext(2804, 39, false);
#line 62 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
                                                      Write(Model.CreateDate.ToString("yyyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(2843, 320, true);
                WriteLiteral(@"</time>
                        </a>
                    </div>
                    <div class=""article-inner"">
                        <input type=""hidden"" class=""isFancy"" />
                        <header class=""article-header"">
                            <h1 itemprop=""name"">
                                ");
                EndContext();
                BeginContext(3164, 11, false);
#line 69 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
                           Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3175, 176, true);
                WriteLiteral("\r\n                            </h1>\r\n                        </header>\r\n                        <div class=\"article-entry\" itemprop=\"articleBody\">\r\n                            ");
                EndContext();
                BeginContext(3352, 20, false);
#line 73 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
                       Write(Html.Raw(Model.Body));

#line default
#line hidden
                EndContext();
                BeginContext(3372, 302, true);
                WriteLiteral(@"
                        </div>
                        <div class=""article-info article-info-index"">
                            <div class=""article-tag tagcloud"">
                                <ul class=""article-tag-list"">
                                    <li class=""article-tag-list-item"">");
                EndContext();
                BeginContext(3674, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11b81da5c16f49828011cd3587cb5c81", async() => {
                    BeginContext(3764, 18, false);
#line 78 "C:\Users\MY\source\repos\MyBlogDemo\My.Blog.Web\Views\Blog\Show.cshtml"
                                                                                                                                                          Write(Model.CategoryName);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tag", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tag"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3786, 295, true);
                WriteLiteral(@"</li>
                                </ul>
                            </div>
                            <div class=""clearfix""></div>
                        </div>
                    </div>
                </article>
            </div>
        </div>
    </div>
    <div>
        ");
                EndContext();
                BeginContext(4081, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56fc38296bec4f2a87360c13a71297b5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4144, 118, true);
                WriteLiteral("\r\n        <script type=\"text/javascript\" src=\"assets/shared/scripts/jquery.codecomb.fileupload.js\"></script>\r\n        ");
                EndContext();
                BeginContext(4262, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3504e0b0b4d64e22995632bea6685040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4315, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4325, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f51581ef6183495abc0f4aaa80609b6b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4370, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(4380, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc8ed7333d1146ba99fed8abaf836106", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4428, 397, true);
                WriteLiteral(@"
        <script>
            var yiliaConfig = {
                fancybox: true,
                mathjax: true,
                animate: true,
                isHome: true,
                isPost: false,
                isArchive: false,
                isTag: false,
                isCategory: false,
                open_in_new: false
            }
        </script>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4832, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<My.Blog.Model.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
