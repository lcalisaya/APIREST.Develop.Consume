#pragma checksum "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4acba20a366db3ea43b958923234f91f2f0f06b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Program_GetAllTVPrograms), @"mvc.1.0.view", @"/Views/Program/GetAllTVPrograms.cshtml")]
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
#line 1 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\_ViewImports.cshtml"
using APIREST.MongoDB.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\_ViewImports.cshtml"
using APIREST.MongoDB.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4acba20a366db3ea43b958923234f91f2f0f06b", @"/Views/Program/GetAllTVPrograms.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d800706bf277926f172f770aa2c7b50fc2e7be41", @"/Views/_ViewImports.cshtml")]
    public class Views_Program_GetAllTVPrograms : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<APIREST.MongoDB.Data.TVProgram>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTVProgram", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
  
    ViewData["Title"] = "All TV Programs";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All TV Programs</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4acba20a366db3ea43b958923234f91f2f0f06b3859", async() => {
                WriteLiteral("Create New TV Program");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n    ");
#nullable restore
#line 16 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
Write(TempData["message"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n        <span aria-hidden=\"true\">&times;</span>\r\n    </button>\r\n</div>\r\n");
#nullable restore
#line 21 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.Driver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.Schedule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.TVChannel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.ThereAreGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.IsLiveBroadcast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Driver));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 66 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Schedule));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 69 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.TVChannel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.ThereAreGuests));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.IsLiveBroadcast));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.ActionLink("Edit", "EditTVProgram", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 82 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.ActionLink("Details", "GetTVProgramDetails", new { id=item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 83 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 86 "C:\Users\timea\source\repos\APIREST.Develop.Consume\APIREST.MongoDB.UI\Views\Program\GetAllTVPrograms.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<APIREST.MongoDB.Data.TVProgram>> Html { get; private set; }
    }
}
#pragma warning restore 1591
