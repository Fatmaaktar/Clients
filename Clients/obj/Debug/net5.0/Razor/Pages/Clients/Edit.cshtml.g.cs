#pragma checksum "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bf1875c2b9cd34467dc02dca580146bbcee00c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Clients.Pages_Clients_Edit), @"mvc.1.0.razor-page", @"/Pages/Clients/Edit.cshtml")]
namespace WebApp.Pages.Clients
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
#line 1 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bf1875c2b9cd34467dc02dca580146bbcee00c2", @"/Pages/Clients/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54a580a236bf4511f2b8e02a6219a9844921dafb", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<br />\r\n<h2>Edit Client</h2>\r\n");
#nullable restore
#line 8 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\'alert alert-warning alert-dismissible fade show\' role=\"alert\">\r\n        <strong>");
#nullable restore
#line 11 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\"btn-close\" data-bs-bismiss=\"alert\" aria-label=\"Close\"></button>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bf1875c2b9cd34467dc02dca580146bbcee00c24174", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 424, "\"", 452, 1);
#nullable restore
#line 16 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 432, Model.clientInfo.id, 432, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 642, "\"", 672, 1);
#nullable restore
#line 20 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 650, Model.clientInfo.name, 650, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Email</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 892, "\"", 923, 1);
#nullable restore
#line 26 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 900, Model.clientInfo.email, 900, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Phone</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
                BeginWriteAttribute("value", " value=\"", 1143, "\"", 1174, 1);
#nullable restore
#line 32 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1151, Model.clientInfo.phone, 1151, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Address</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
                BeginWriteAttribute("value", " value=\"", 1398, "\"", 1431, 1);
#nullable restore
#line 38 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1406, Model.clientInfo.address, 1406, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 42 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                    <strong>");
#nullable restore
#line 47 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <button type=\"button\" class=\"btn-close\" data-bs-bismiss=\"alert\" aria-label=\"Close\"></button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 52 "C:\Users\W10\source\repos\WebApp\WebApp\Pages\Clients\Edit.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp.Pages.Clients.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Clients.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApp.Pages.Clients.EditModel>)PageContext?.ViewData;
        public WebApp.Pages.Clients.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
