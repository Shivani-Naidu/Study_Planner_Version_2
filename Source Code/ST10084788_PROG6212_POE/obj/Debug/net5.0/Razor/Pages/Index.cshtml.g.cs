#pragma checksum "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7988390e197dee7fcfb79da49b97cf476dcc4458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ST10084788_PROG6212_POE.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ST10084788_PROG6212_POE.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7988390e197dee7fcfb79da49b97cf476dcc4458", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a429e8aebc6359a5381762cc5141ce8c4df7f0a7", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\" >\r\n   \r\n    <h9 class=\"display-4\">Welcome,</h9>\r\n\r\n    <dl class=\"row\">\r\n        <dd class=\"col-sm-12\">\r\n            ");
#nullable restore
#line 13 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Index.cshtml"
       Write(Html.DisplayFor(model => Model.DelegateUser));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <dl class=\"row\">\r\n        <dd class=\"col-sm-12\">\r\n            ");
#nullable restore
#line 19 "C:\Users\shiva\OneDrive\Desktop\VC\Second Year\Semester 2\PROG6212\ST10084788_PROG6212_POE_PART_3\Source Code\ST10084788_PROG6212_POE\Pages\Index.cshtml"
       Write(Html.DisplayFor(model => Model.message1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>
    </dl>    
</div>


<div class=""row"">
    <div class=""col-md-4"" style=""background-color: lightblue"">
        <h2>Time Management Website</h2>
        <p>
            The Time Management Web Application Was Created For My
            Prog6212 Portfolio.
            This Web Application Was Developed With The Intention
            Of Helping Students To Manage Their Time Efficiently And
            Achieve All Their Academic Goals. 
        </p>

    </div>

    <div class=""col-md-4"" style=""background-color: mediumpurple"">
        <h2> Documentation For The Website</h2>
        <p>
            All Documentation (Specs/Versions/Plugins, etc.) 
            For The Web Application
            Can Be Found Here 
            
           
        <p>
        <p>
      
            ↓

        <p>

            <a class=""btn btn-primary"" style=""background-color:transparent; color:darkblue; border:dotted""
               href=""https://github.com/niniiibae/ST10084788_PRO");
            WriteLiteral(@"G6212_POE_PART_3/tree/master#readme"">Documentation</a>
       
    </div>


    <div class=""col-md-4"" style=""background-color:lightblue"">
        <h2> About Us - Github Repository </h2>
        <p>
            Access And Download The Source Code For The 
            Time Management Web Application Here
            
        <p>
        <p>

            ↓

        <p>

            <a class=""btn btn-primary"" style=""background-color:transparent; color:darkblue; border:dotted""
               href=""https://github.com/niniiibae/ST10084788_PROG6212_POE_PART_3/tree/master"">Github Repository </a>
        

    </div>


</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591