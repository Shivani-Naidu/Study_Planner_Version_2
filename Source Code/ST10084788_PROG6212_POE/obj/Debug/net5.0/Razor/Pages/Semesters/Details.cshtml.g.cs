#pragma checksum "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8bb2838eb26862ba362d70c98cd5181b1b14c100"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ST10084788_PROG6212_POE.Pages.Semesters.Pages_Semesters_Details), @"mvc.1.0.razor-page", @"/Pages/Semesters/Details.cshtml")]
namespace ST10084788_PROG6212_POE.Pages.Semesters
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
#line 1 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\_ViewImports.cshtml"
using ST10084788_PROG6212_POE;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bb2838eb26862ba362d70c98cd5181b1b14c100", @"/Pages/Semesters/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a429e8aebc6359a5381762cc5141ce8c4df7f0a7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Semesters_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:darkblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Semester Summary</h1>\r\n\r\n");
            WriteLiteral("\r\n<div>\r\n    <h4></h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Semester.SemesterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Semester.SemesterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Semester.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Semester.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Semester.SemesterWeeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Semester.SemesterWeeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Semester.SemesterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Details.cshtml"
       Write(Html.DisplayFor(model => model.Semester.SemesterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n   \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8bb2838eb26862ba362d70c98cd5181b1b14c1007669", async() => {
                WriteLiteral("Back To Semesters");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ST10084788_PROG6212_POE.Pages.Semesters.DetailsModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ST10084788_PROG6212_POE.Pages.Semesters.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ST10084788_PROG6212_POE.Pages.Semesters.DetailsModel>)PageContext?.ViewData;
        public ST10084788_PROG6212_POE.Pages.Semesters.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
