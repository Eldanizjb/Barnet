#pragma checksum "C:\Users\ACER\source\repos\Barnet\Barnet\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756353a85db42b1115edbbd0cec97aff6a1d2927"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\ACER\source\repos\Barnet\Barnet\Views\_ViewImports.cshtml"
using Barnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\source\repos\Barnet\Barnet\Views\_ViewImports.cshtml"
using Barnet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ACER\source\repos\Barnet\Barnet\Views\_ViewImports.cshtml"
using Barnet.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ACER\source\repos\Barnet\Barnet\Views\_ViewImports.cshtml"
using Barnet.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756353a85db42b1115edbbd0cec97aff6a1d2927", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"443da313e07311488749f133e44aa17e8afdf348", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form style-seven"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://html.commonsupport.xyz/2019/Barnet/inc/sendmail.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://html.commonsupport.xyz/2019/Barnet/contact.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ACER\source\repos\Barnet\Barnet\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Contact Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page title -->
<section class=""page-title"" style=""background-image:url(images/background/3.jpg)"">
    <div class=""container"">
        <div class=""outer-box"">
            <h1>Contact Us</h1>
            <ul class=""bread-crumb clearfix"">
                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756353a85db42b1115edbbd0cec97aff6a1d29276688", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                <li class=""active"">Contact Us</li>
            </ul>
        </div>
    </div>
</section>

<!-- map section -->
<section class=""map-section sp-four"">
    <div class=""container"">
        <div class=""home-google-map"">
            <div class=""google-map""
                 id=""contact-google-map""
                 data-map-lat=""54.194328""
                 data-map-lng=""-2.916747""
                 data-icon-path=""images/icons/map-marker.png""
                 data-map-title=""Chester""
                 data-map-zoom=""11"">
            </div>
        </div>
    </div>

</section>

<!-- Contact section -->
<section class=""contact-section sp-six"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <div class=""contact-info"">
                    <h2>We???re Happy to Discuss <br> Your Project  and Answer <br>any Question</h2>
                    <div class=""contact-info-block"">
                        <h5>Address</h5>
  ");
            WriteLiteral(@"                      <div class=""text"">77408 Satterfield Motorway Suite 469 New Antonetta, BC K3L6P6</div>
                    </div>
                    <div class=""contact-info-block"">
                        <h5>Email</h5>
                        <div class=""text"">hello@example.com</div>
                    </div>
                    <div class=""contact-info-block"">
                        <h5>Phone</h5>
                        <div class=""text"">(+081) 325 665 9487</div>
                    </div>
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""default-form-area"">
                    <div class=""sec-title light mb-20"">
                        <h1>Let???s Start <br>The Conversation.</h1>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756353a85db42b1115edbbd0cec97aff6a1d29279683", async() => {
                WriteLiteral(@"
                        <div class=""row clearfix"">
                            <div class=""col-md-6 column"">
                                <div class=""form-group"">
                                    <input type=""text"" name=""form_name"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 2618, "\"", 2626, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your Name\"");
                BeginWriteAttribute("required", " required=\"", 2651, "\"", 2662, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""col-md-6 column"">
                                <div class=""form-group"">
                                    <input type=""email"" name=""form_email"" class=""form-control required email""");
                BeginWriteAttribute("value", " value=\"", 2968, "\"", 2976, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\"");
                BeginWriteAttribute("required", " required=\"", 2997, "\"", 3008, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>
                            <div class=""col-md-6 column"">
                                <div class=""form-group"">
                                    <input type=""text"" name=""form_phone"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3298, "\"", 3306, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Phone Number"">
                                </div>
                            </div>
                            <div class=""col-md-6 column"">
                                <div class=""form-group"">
                                    <input type=""text"" name=""form_subject"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 3625, "\"", 3633, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Subject"">
                                </div>
                            </div>
                            <div class=""col-md-12 column"">
                                <div class=""form-group"">
                                    <textarea name=""form_message"" class=""form-control textarea required"" placeholder=""Message""></textarea>
                                </div>
                            </div>
                        </div>
                        <div class=""contact-section-btn"">
                            <div class=""form-group style-two"">
                                <input id=""form_botcheck"" name=""form_botcheck"" class=""form-control"" type=""hidden""");
                BeginWriteAttribute("value", " value=\"", 4337, "\"", 4345, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <button class=\"theme-btn btn-style-two\" type=\"submit\" data-loading-text=\"Please wait...\">Submit Here</button>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <!-- End form -->
            </div>
        </div>
    </div>
</section>

<!-- Subscribe section -->
<section class=""subscribe-section"">
    <div class=""container"">
        <div class=""outer-box"">
            <div class=""row"">
                <div class=""title-column col-lg-6"">
                    <h2>Subscribe <br>to Our Newsletter</h2>
                </div>
                <div class=""subscribe-form col-lg-6"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756353a85db42b1115edbbd0cec97aff6a1d292715283", async() => {
                WriteLiteral("\r\n                        <div class=\"form-group\">\r\n                            <input type=\"email\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 5278, "\"", 5286, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Your email...\"");
                BeginWriteAttribute("required", " required=\"", 5315, "\"", 5326, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <button type=\"submit\" class=\"theme-btn btn-style-six\">Subscribe Now</button>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
