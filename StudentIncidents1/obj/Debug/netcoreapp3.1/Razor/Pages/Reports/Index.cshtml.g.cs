#pragma checksum "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8177d12d9145e0e4ed5d2ac46b8ec7cdbd6daa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentIncidents1.Pages.Reports.Pages_Reports_Index), @"mvc.1.0.razor-page", @"/Pages/Reports/Index.cshtml")]
namespace StudentIncidents1.Pages.Reports
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
#line 1 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\_ViewImports.cshtml"
using StudentIncidents1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\_ViewImports.cshtml"
using StudentIncidents1.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8177d12d9145e0e4ed5d2ac46b8ec7cdbd6daa7", @"/Pages/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7568808d5d8930c83e2eb15a6268b12c71866c56", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Reports_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8177d12d9145e0e4ed5d2ac46b8ec7cdbd6daa73886", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentIncident[0].Student));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentIncident[0].Incident));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentIncident[0].IncidentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Student Total\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
 foreach (var item in Model.StudentIncident) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Student.StudentFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Incident.IncidentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IncidentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "P:\ASPNET_github_michaelbz1\ASPNET\StudentIncidents1\Pages\Reports\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentIncidents1.Pages.StudentIncidents.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentIncidents1.Pages.StudentIncidents.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<StudentIncidents1.Pages.StudentIncidents.IndexModel>)PageContext?.ViewData;
        public StudentIncidents1.Pages.StudentIncidents.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
