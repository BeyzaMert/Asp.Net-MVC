#pragma checksum "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogReadAll), @"mvc.1.0.view", @"/Views/Blog/BlogReadAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f", @"/Views/Blog/BlogReadAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogReadAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/web/images/b1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/CoreBlogTema/web/images/banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
  
    ViewData["Title"] = "BlogReadAll";
    Layout = "~/Views/Shared/UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"zxx\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f5096", async() => {
                WriteLiteral("\r\n\t<!--//banner-->\r\n\t<section class=\"banner-bottom\">\r\n\t\t<!--/blog-->\r\n\t\t<div class=\"container\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<!--left-->\r\n\t\t\t\t<div class=\"col-lg-8 left-blog-info-w3layouts-agileits text-left\">\r\n");
#nullable restore
#line 18 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                     foreach (var item in Model)
					{

#line default
#line hidden
#nullable disable
                WriteLiteral("\t\t\t\t\t<div class=\"blog-grid-top\">\r\n\t\t\t\t\t\t<div class=\"b-grid-top\">\r\n\t\t\t\t\t\t\t<div class=\"blog_info_left_grid\">\r\n\t\t\t\t\t\t\t\t<a href=\"single.html\">\r\n\t\t\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f6049", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"blog-info-middle\">\r\n\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t\t\t<i class=\"far fa-calendar-alt\"></i> ");
#nullable restore
#line 31 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                                                            Write(((DateTime)
											item.BlogCreateDate).ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
										</a>
									</li>
									<li class=""mx-2"">
										<a href=""#"">
											<i class=""far fa-thumbs-up""></i> 0 Beğeni
										</a>
									</li>
									<li>
										<a href=""#"">
											<i class=""far fa-comment""></i> 0 Yorum
										</a>
									</li>

								</ul>
							</div>
						</div>

						<h3>
							<a href=""single.html"">");
#nullable restore
#line 51 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                                             Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </a>
						</h3>
						<p>
							Lorem ipsum dolor sit amet consectetur adipisicing elit sedc dnmo eiusmod tempor incididunt ut labore et dolore magna
							aliqua uta enim ad minim ven iam quis nostrud exercitation ullamco labor nisi ut aliquip exea commodo consequat duis
							aute irudre dolor in elit sed uta labore dolore reprehender
						</p>
						<a href=""single.html"" class=""btn btn-primary read-m"">Blog Listesi</a>
					</div>
");
#nullable restore
#line 60 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
					}

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t");
#nullable restore
#line 63 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Component.InvokeAsync("CommentListByBlog",new {id=ViewBag.i}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\t\t\t\t\t");
#nullable restore
#line 66 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
               Write(await Html.PartialAsync("~/Views/Comment/PartialAddComment.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\r\n\t\t\t\t<!--//left-->\r\n\t\t\t\t<!--right-->\r\n\t\t\t\t<aside class=\"col-lg-4 agileits-w3ls-right-blog-con text-right\">\r\n\t\t\t\t\t<div class=\"right-blog-info text-left\">\r\n\t\t\t\t\t\t<div class=\"tech-btm\">\r\n\t\t\t\t\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f10116", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<h4>Mail Bültenine abone olun</h4>\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 78 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Html.PartialAsync("~/Views/NewsLetter/SubscribeMail.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 80 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 82 "C:\Users\beyza\source\repos\CoreDemo\CoreDemo\Views\Blog\BlogReadAll.cshtml"
                   Write(await Component.InvokeAsync("WriterLastBlog"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

						<div class=""single-gd my-5 tech-btm"">
							<h4>Our Progress</h4>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0""
									 aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-success"" role=""progressbar"" style=""width: 25%"" aria-valuenow=""25"" aria-valuemin=""0""
									 aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-info"" role=""progressbar"" style=""width: 50%"" aria-valuenow=""50"" aria-valuemin=""0""
									 aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""progress-bar progress-bar-striped bg-warning"" role=""progressbar"" style=""width: 75%"" aria-valuenow=""75"" aria-valuemin=""0""
									 aria-valuemax=""100""></div>
							</div>
							<div class=""progress"">
								<div class=""prog");
                WriteLiteral(@"ress-bar progress-bar-striped bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0""
									 aria-valuemax=""100""></div>
							</div>
						</div>
						<div class=""single-gd tech-btm"">
							<h4>Son Eklenen Post</h4>
							<div class=""blog-grids"">
								<div class=""blog-grid-left"">
									<a href=""single.html"">
										");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5922a7c54dbcba3f6a61b726c7a2f3e0652aa93f13838", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
									</a>
								</div>
								<div class=""blog-grid-right"">

									<h5>
										<a href=""single.html"">Pellentesque dui, non felis. Maecenas male</a>
									</h5>
								</div>
								<div class=""clearfix""> </div>
							</div>
						</div>
					</div>

				</aside>
				<!--//right-->
			</div>
		</div>
	</section>

");
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
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
