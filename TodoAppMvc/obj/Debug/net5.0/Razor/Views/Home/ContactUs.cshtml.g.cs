#pragma checksum "C:\Users\User\Desktop\DotNet\TodoAppMvcCode\TodoAppMvc\Views\Home\ContactUs.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b8218d508f45263f2aaa56bf255b30f13abcf76abfc9400f76c24b54f3c60c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Home_ContactUs), @"mvc.1.0.view", @"/Views/Home/ContactUs.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\Desktop\DotNet\TodoAppMvcCode\TodoAppMvc\Views\_ViewImports.cshtml"
using TodoAppMvc

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\User\Desktop\DotNet\TodoAppMvcCode\TodoAppMvc\Views\_ViewImports.cshtml"
using TodoAppMvc.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b8218d508f45263f2aaa56bf255b30f13abcf76abfc9400f76c24b54f3c60c24", @"/Views/Home/ContactUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"faf117aa75bbd523c6bcc3e8b73c152c95f0051b7cbfd9b4c31230f92dcbba02", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Home_ContactUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\User\Desktop\DotNet\TodoAppMvcCode\TodoAppMvc\Views\Home\ContactUs.cshtml"
  
    ViewBag.Title = "ContactUs";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"jumbotron\">\r\n            <h1 class=\"text-center\">Contact Us</h1>\r\n            <h3 class=\"text-center\">Please fill out the form below to get in touch with us</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b8218d508f45263f2aaa56bf255b30f13abcf76abfc9400f76c24b54f3c60c244499", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-6"">
                        <div class=""mb-3"">
                            <label for=""name"" class=""form-label"">Name</label>
                            <input type=""text"" class=""form-control"" id=""name"" name=""name"" required />
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <div class=""mb-3"">
                            <label for=""email"" class=""form-label"">Email</label>
                            <input type=""email"" class=""form-control"" id=""email"" name=""email"" required />
                        </div>
                    </div>
                </div>
                <div class=""mb-3"">
                    <label for=""message"" class=""form-label"">Message</label>
                    <textarea class=""form-control"" id=""message"" name=""message"" required></textarea>
                </div>
                <div class=""text-center"">
                 ");
                WriteLiteral("   <button type=\"submit\" class=\"btn-primary\">Submit</button>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    </div>
</div>
<div class=""row mb-4"">
    <div class=""col-sm-6"">
        <div class=""card"" class=""text-center"" class=""col-md-6"">
            <div class=""card-header bg-dark text-white text-center"">Contact Us Via Email & Mobile</div>
            <div class=""row mb-4"">
                <div class=""col-sm-6"">
                    <div class=""card"" class=""text-center"" class=""col-md-6"">
                        <h5 class=""card-header bg-gray text-center"">Email</h5>
                        <a href=""https://accounts.google.com/v3/signin/identifier?dsh=S1259000116%3A1687930108398110&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=Af_xneENilgs4klwbKRHPb6uGl6VNO9qjKmY8EVuzpy5kVlX6-RrKOPVwZTxy21Ese5NKlGyBZIfAQ&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"">todoindia@gmail.com</a>
                        <a href=""https://accounts.google.com/v3/signin/identifier?dsh=S1259000116%3A1687930108398110&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=Af_xneENilgs");
            WriteLiteral(@"4klwbKRHPb6uGl6VNO9qjKmY8EVuzpy5kVlX6-RrKOPVwZTxy21Ese5NKlGyBZIfAQ&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"">todoUS@gmail.com</a>
                        <a href=""https://accounts.google.com/v3/signin/identifier?dsh=S1259000116%3A1687930108398110&continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&ifkv=Af_xneENilgs4klwbKRHPb6uGl6VNO9qjKmY8EVuzpy5kVlX6-RrKOPVwZTxy21Ese5NKlGyBZIfAQ&rip=1&sacu=1&service=mail&flowName=GlifWebSignIn&flowEntry=ServiceLogin"">todoUK@gmail.com</a>
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""card"">
                        <h5 class=""card-header bg-gray text-center"">Mobile</h5>
                        <a>India +919753343088</a>
                        <a>United States +1555-555-1234</a>
                        <a>United Kingdom +447946-0999</a>
                    </div>
                </div>
            </div>
            <h6 class=""text-center bg-dark text-white"">We a");
            WriteLiteral(@"re availabe for 24*7 for any location </h6>
        </div>
    </div>
    <div class=""col-sm-6"">
        <div class=""card"">
            <div class=""card-header bg-dark text-white text-center"">Contact Us Via Social Platform</div>
            <div class=""card-body bg-gray"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <a href=""https://www.facebook.com/login/"">
                            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRv0_QqgklbGadrMrw6zFjuyt3XJliuKqBhV2OxRjkunw&s"" />
                        </a>
                    </div>
                    <div class=""col-md-4"">
                        <a href=""https://www.instagram.com/accounts/login/"">
                            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcThdIDypl-B-Da92vI4xvK1_lYV2Y6e6cbPgJPwc2Aigg&s"" />
                        </a>
                    </div>
                    <div class=""col-md-4"">
                        <a ");
            WriteLiteral(@"href=""https://twitter.com/i/flow/login?input_flow_data=%7B%22requested_variant%22%3A%22eyJsYW5nIjoiZW4ifQ%3D%3D%22%7D"">
                            <img src=""https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQwKw2LnY2-8v8FqBBLT8eZMtbUF6wNZpEwryISCSc1&s"">
                        </a>
                    </div>

                </div>
                

            </div>
        </div>
    </div>
</div>

<!--Footer Mangesh-->
<footer class=""bg-dark text-light py-3 mt-5"">
    <div class=""container text-center"">
        <p>&copy; 2023 Your To-Do App. All rights reserved, created by MP.</p>
    </div>
</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591