#pragma checksum "C:\Users\Administrator\Documents\Dev\Clarity\ClarityWebApp\ClarityWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f27924f5108c78e1823306184c0dfd4a5dfbf28"
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
#line 1 "C:\Users\Administrator\Documents\Dev\Clarity\ClarityWebApp\ClarityWebApp\Views\_ViewImports.cshtml"
using ClarityWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Documents\Dev\Clarity\ClarityWebApp\ClarityWebApp\Views\_ViewImports.cshtml"
using ClarityWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f27924f5108c78e1823306184c0dfd4a5dfbf28", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03159a6a1052c4a72c1ee5e6d79e266f73ac690f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formEmail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Administrator\Documents\Dev\Clarity\ClarityWebApp\ClarityWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section id=""hero"" class=""d-flex align-items-center"">
    <div class=""container text-center"">

        <div class=""bullet"" data-aos=""zoom-out"" data-aos-delay=""100"">
            <h1>
                <span>The Client's Site</span>
            </h1>
        </div>
        <div id=""form-input"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f27924f5108c78e1823306184c0dfd4a5dfbf284455", async() => {
                WriteLiteral(@"
                <div class=""form-group row"">
                    <div class=""col-sm-6"">
                        <div class=""input-group"">
                            <label for=""toemail"" class=""col-sm-2 col-form-label"">TO: </label>
                            <input type=""email"" name=""toemail""");
                BeginWriteAttribute("value", " value=\"", 690, "\"", 698, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""friend@email.com"" id=""toemail"" class=""form-control"" />
                        </div>
                        <div class=""input-group"">
                            <label for=""fromemail"" class=""col-sm-2 col-form-label"">FROM: </label>
                            <input type=""email"" name=""fromemail""");
                BeginWriteAttribute("value", " value=\"", 1015, "\"", 1023, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""you@email.com"" id=""fromemail"" class=""form-control"" />
                        </div>
                        <div class=""input-group"">
                            <label for=""subject"" class=""col-sm-2 col-form-label"">Subject: </label>
                            <input type=""text"" name=""subject""");
                BeginWriteAttribute("value", " value=\"", 1337, "\"", 1345, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""whats up?!"" id=""subject"" class=""form-control"" />
                        </div>
                        <div class=""input-group"">
                            <label for=""body"" class=""col-sm-2 col-form-label"">Message: </label>
                            <input type=""text"" name=""body""");
                BeginWriteAttribute("value", " value=\"", 1648, "\"", 1656, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""just checking in..."" id=""body"" class=""form-control"" />
                        </div>
                        <div class=""input-group"">
                            <button class=""btn btn-primary"" type=""submit"" id=""btnSubmit"">Submit</button>
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div id=""success-cont"" class=""alert alert-success"" style=""display:none;"">
            <span>Thanks. Email will be sent</span>
        </div>
    </div>
</section>




<section id=""main"">



    <section id=""featured-services"" class=""featured-services"">
        <div class=""container"" data-aos=""fade-up"">
            <div class=""section-title"">
                <h2>No Interuption</h2>
                <h3>Even if sending an email <span>Fails</span> :(</h3>
            </div>
            <div class=""row"">

                <div class=""col-md-6 col-lg-4 d-flex align-items-stretch mb-5 mb-lg-0"">
                    <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""200"">
                        <div class=""icon""><i class=""bx bx-file""></i></div>
                        <h4 class=""title""><span>1/3</span>Fill in the information</h4>
                        <p class=""description"">Use the form above to enter in the email information that you want to send</p>
       ");
            WriteLiteral(@"             </div>
                </div>

                <div class=""col-md-6 col-lg-4 d-flex align-items-stretch mb-5 mb-lg-0"">
                    <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""300"">
                        <div class=""icon""><i class=""bx bx-group""></i></div>
                        <h4 class=""title""><span>2/3</span>Click Submit!</h4>
                        <p class=""description"">Once submitted, the jQuery will send the API a request to send the email information</p>
                    </div>
                </div>

                <div class=""col-md-6 col-lg-4 d-flex align-items-stretch mb-5 mb-lg-0"">
                    <div class=""icon-box"" data-aos=""fade-up"" data-aos-delay=""400"">
                        <div class=""icon""><i class=""bx bx-code""></i></div>
                        <h4 class=""title""><span>3/3</span>Async Process</h4>
                        <p class=""description"">The API will asyncronously send the email so you can carry on about the site</p>
  ");
            WriteLiteral("                  </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </section>\r\n\r\n</section>\r\n");
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
