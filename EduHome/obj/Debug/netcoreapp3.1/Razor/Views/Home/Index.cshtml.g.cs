#pragma checksum "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f864c975f97a9742872e246e6155ba6676eac9f"
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
#line 1 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\_ViewImports.cshtml"
using EduHome.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f864c975f97a9742872e246e6155ba6676eac9f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ab98eb3d16c0c040939bb7fc240655b873f319", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://devitems.us11.list-manage.com/subscribe/post?u=6bbb9b6f5827bd842d9640c82&amp;id=05d85f18ef"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("mc-embedded-subscribe-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("validate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<!-- Background Area Start -->\r\n        <section id=\"slider-container\" class=\"slider-area\"> \r\n            <div class=\"slider-owl owl-theme owl-carousel\"> \r\n");
#nullable restore
#line 9 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                 foreach (var item in Model.sliders)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <!-- Start Slingle Slide -->\r\n                <div class=\"single-slide item\"");
            BeginWriteAttribute("style", " style=\"", 380, "\"", 433, 4);
            WriteAttributeValue("", 388, "background-image:", 388, 17, true);
            WriteAttributeValue(" ", 405, "url(img/slider/", 406, 16, true);
#nullable restore
#line 12 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 421, item.Image, 421, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 432, ")", 432, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    <!-- Start Slider Content -->
                    <div class=""slider-content-area"">  
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-md-7 col-md-offset-left-5""> 
                                    <div class=""slide-content-wrapper"">
                                        <div class=""slide-content"">
                                             <h3>");
#nullable restore
#line 20 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                            Write(Html.Raw(Model.pageIntros.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                                            \r\n                                            <p>\r\n                                                ");
#nullable restore
#line 23 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                           Write(Model.pageIntros.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </p>
                                            <a class=""default-btn"" href=""about.html"">Learn more</a>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- Start Slider Content -->
                </div>
                <!-- End Slingle Slide -->
");
#nullable restore
#line 35 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                
                								
            </div>
        </section>
		<!-- Background Area End -->
        <!-- Notice Start -->
        <section class=""notice-area pt-150 pb-150"">
            <div class=""container"">
                <div class=""row"">
                 
                       <div class=""col-md-6 col-sm-6 col-xs-12"">
                        <div class=""notice-left"">
                            <h3>notice board</h3>
");
#nullable restore
#line 49 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                            foreach (var item in Model.noticeBoards)
                          {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"single-notice-left pb-70\">\r\n                                <h4>");
#nullable restore
#line 52 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                               Write(item.Date.ToString("dd MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <p>");
#nullable restore
#line 53 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\n");
#nullable restore
#line 55 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\n                 \r\n                    <div class=\"col-md-6 col-sm-6 col-xs-12\">\r\n                        <div class=\"notice-right\">\r\n");
#nullable restore
#line 61 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                             foreach (var item in Model.noticeRightInfos)
                           {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <div class=\"single-notice-right mb-25 pb-25\">\r\n                                <h3>");
#nullable restore
#line 64 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                <p>");
#nullable restore
#line 65 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div> \n");
#nullable restore
#line 67 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- Notice End -->
        <!-- Choose Start -->
        <section class=""choose-area pb-85 pt-77"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8 col-md-offset-left-4 col-sm-8 col-md-offset-left-4"">
                        <div class=""choose-content text-left"">
                            <h2>WHY YOU CHOOSE EDUHOME ?</h2>
                            <p>I must explain to you how all this mistaken idea of denouncing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder of humanit happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because. </p>
                            <p class=""choose-option"">I must explain to you how all this mistaken idea of denounc");
            WriteLiteral(@"ing pleure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings  the master-builder. </p>
                            <a class=""default-btn"" href=""course-details.html"">view courses</a>
                        </div>  
                    </div>
                </div>
            </div>
        </section>
        <!-- Choose Area End -->
        <!-- Courses Area Start -->
        <div class=""courses-area pt-150 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>COURSES WE OFFER</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 103 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                     foreach (var item in Model.courses)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                        <div class=\"single-course\">\r\n                            <div class=\"course-img\">\r\n                                <a href=\"course-details.html\"><img");
            BeginWriteAttribute("src", " src=\"", 5284, "\"", 5312, 2);
            WriteAttributeValue("", 5290, "img/course/", 5290, 11, true);
#nullable restore
#line 108 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 5301, item.Image, 5301, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""course"">
                                    <div class=""course-hover"">
                                        <i class=""fa fa-link""></i>
                                    </div>
                                </a>
                            </div>
                            <div class=""course-content"">
                                <h3><a href=""course-details.html"">");
#nullable restore
#line 115 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                             Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <p>");
#nullable restore
#line 116 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n                            </div>   \r\n                        </div>\r\n                    </div>\n");
#nullable restore
#line 121 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <!-- Courses Area End -->
        <!-- Event Area Start -->
        <div class=""event-area one text-center pt-140 pb-150"">
            <div class=""container"">
                <div class=""row"">
                     <div class=""col-xs-12"">
                        <div class=""section-title"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>UPCOMMING EVENTS</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 138 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                  foreach (var item in Model.upCommingEvents)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-md-6 col-sm-12 col-xs-12\">\r\n                        <div class=\"single-event mb-35\">\r\n                            <div class=\"event-date\">\r\n                                <h3><a href=\"event-details.html\">");
#nullable restore
#line 143 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                            Write(item.Day.ToString("dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>");
#nullable restore
#line 143 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                                          Write(item.Month.ToString("MMMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></a></h3>
                            </div>
                            <div class=""event-content text-left"">
                                <div class=""event-content-left"">
                                    <h4><a href=""event-details.html"">");
#nullable restore
#line 147 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n                                    <ul>\r\n                                        <li><i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 149 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                    Write(item.StartTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" -");
#nullable restore
#line 149 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                                                          Write(item.EndTime.ToString("hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li><i class=\"fa fa-map-marker\"></i>");
#nullable restore
#line 150 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                       Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                                <div class=""event-content-right"">
                                    <a class=""default-btn"" href=""event-details.html"">join now</a>
                                </div>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 159 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                </div>
            </div>
        </div>
        <!-- Event Area End -->
        <!-- Testimonial Area Start -->
        <div class=""testimonial-area pt-110 pb-105 text-center"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""testimonial-owl owl-theme owl-carousel"">
                        <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                            <div class=""single-testimonial"">
                                <div class=""testimonial-info"">
                                    <div class=""testimonial-img"">
                                        <img src=""img/testimonial/testimonial.jpg"" alt=""testimonial"">
                                    </div>
                                    <div class=""testimonial-content"">
                                        <p>I must explain to you how all this mistaken idea of denoung pleure and praising pain was born and I will give you a coete account");
            WriteLiteral(@" of the system, and expound the actual</p>
                                        <h4>David Morgan</h4>
                                        <h5>Student, CSE</h5>
                                    </div>
                                </div>
                            </div>
                        </div> 
                    </div>
                </div>
            </div>
        </div>
        <!-- Testimonial Area End -->
        <!-- Blog Area Start -->
        <div class=""blog-area pt-150 pb-150"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""section-title text-center"">
                            <img src=""img/icon/section.png"" alt=""section-title"">
                            <h2>LATEST FROM BLOG</h2>
                        </div>
                    </div>
                </div>
                <div class=""row"">
");
#nullable restore
#line 201 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                     foreach (var item in Model.blog)
                   {

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                        <div class=\"single-blog\">\r\n                            <div class=\"blog-img\">\r\n                                <a href=\"blog-details.html\"><img");
            BeginWriteAttribute("src", " src=\"", 10276, "\"", 10302, 2);
            WriteAttributeValue("", 10282, "img/blog/", 10282, 9, true);
#nullable restore
#line 206 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
WriteAttributeValue("", 10291, item.Image, 10291, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""blog""></a>
                                <div class=""blog-hover"">
                                    <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                                </div>
                            </div>
                            <div class=""blog-content"">
                                <div class=""blog-top"">
                                    <p>");
#nullable restore
#line 213 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                  Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("/  ");
#nullable restore
#line 213 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                 Write(item.WriteTime.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" /  <i class=\"fa fa-comments-o\"></i> ");
#nullable restore
#line 213 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                                                                                              Write(item.CommentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <div class=\"blog-bottom\">\r\n                                    <h2><a href=\"blog-details.html\">");
#nullable restore
#line 216 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></h2>\r\n                                    <a href=\"blog-details.html\">read more</a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\n");
#nullable restore
#line 222 "C:\Users\TOSHIBA\Desktop\EduHome\EduHome\Views\Home\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
        <!-- Blog Area End -->
        <!-- Subscribe Start -->
        <div class=""subscribe-area pt-60 pb-70"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-8 col-md-offset-2"">
                        <div class=""subscribe-content section-title text-center"">
                            <h2>subscribe our newsletter</h2>
                            <p>I must explain to you how all this mistaken idea </p>
                        </div>
                        <div class=""newsletter-form mc_embed_signup"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f864c975f97a9742872e246e6155ba6676eac9f25616", async() => {
                WriteLiteral("\r\n                                <div id=\"mc_embed_signup_scroll\" class=\"mc-form\"> \r\n                                    <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 12293, "\"", 12301, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""EMAIL"" class=""email"" id=""mce-EMAIL"" placeholder=""Enter your e-mail address"" required>
                                    <!-- real people should not fill this in and expect good things - do not remove this or risk form bot signups-->
                                    <div class=""mc-news"" aria-hidden=""true""><input type=""text"" name=""b_6bbb9b6f5827bd842d9640c82_05d85f18ef"" tabindex=""-1""");
                BeginWriteAttribute("value", " value=\"", 12700, "\"", 12708, 0);
                EndWriteAttribute();
                WriteLiteral("></div>\r\n                                    <button id=\"mc-embedded-subscribe\" class=\"default-btn\" type=\"submit\" name=\"subscribe\"><span>subscribe</span></button> \r\n                                </div>    \r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <!-- mailchimp-alerts Start -->
                            <div class=""mailchimp-alerts"">
                                <div class=""mailchimp-submitting""></div><!-- mailchimp-submitting end -->
                                <div class=""mailchimp-success""></div><!-- mailchimp-success end -->
                                <div class=""mailchimp-error""></div><!-- mailchimp-error end -->
                            </div>
                            <!-- mailchimp-alerts end -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- Subscribe End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591