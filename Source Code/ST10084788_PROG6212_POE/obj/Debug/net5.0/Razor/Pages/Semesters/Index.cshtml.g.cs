#pragma checksum "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74e4dd7cd3e5c4921d614115fa2ff21834e10936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ST10084788_PROG6212_POE.Pages.Semesters.Pages_Semesters_Index), @"mvc.1.0.razor-page", @"/Pages/Semesters/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74e4dd7cd3e5c4921d614115fa2ff21834e10936", @"/Pages/Semesters/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a429e8aebc6359a5381762cc5141ce8c4df7f0a7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Semesters_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:darkblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Semester Information</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e4dd7cd3e5c4921d614115fa2ff21834e109364493", async() => {
                WriteLiteral("Add A Semester");
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
            WriteLiteral("\r\n</p>\r\n\r\n");
            WriteLiteral("<table class=\"table\" style=\"color:darkblue; background-color:lightblue;\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester[0].SemesterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester[0].Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester[0].SemesterWeeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Semester[0].SemesterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
 foreach (var item in Model.Semester) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SemesterName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SemesterWeeks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SemesterDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74e4dd7cd3e5c4921d614115fa2ff21834e109369646", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
                                                                     WriteLiteral(item.SemesterID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Semesters\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ST10084788_PROG6212_POE.Pages.Semesters.IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ST10084788_PROG6212_POE.Pages.Semesters.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ST10084788_PROG6212_POE.Pages.Semesters.IndexModel>)PageContext?.ViewData;
        public ST10084788_PROG6212_POE.Pages.Semesters.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591