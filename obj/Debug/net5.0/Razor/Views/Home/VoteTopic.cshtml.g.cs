#pragma checksum "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d90ff5bc8626f22b42fb54ed1a2c7f84f20ea97f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_VoteTopic), @"mvc.1.0.view", @"/Views/Home/VoteTopic.cshtml")]
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
#line 1 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\_ViewImports.cshtml"
using Bazadanych;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\_ViewImports.cshtml"
using Bazadanych.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d90ff5bc8626f22b42fb54ed1a2c7f84f20ea97f", @"/Views/Home/VoteTopic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60978b1f624cfd294b6acfcdb70b5064b37846c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_VoteTopic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Bazadanych.Models.TopicModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTopics", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
  
    ViewData["Title"] = "VoteTopic";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>VoteTopic</h1>\r\n\r\n<h4>TopicModel</h4>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        ");
#nullable restore
#line 13 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
   Write(Html.DisplayFor(model => model.OptionA.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        ");
#nullable restore
#line 16 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
   Write(Html.DisplayFor(model => model.OptionB.Information));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        Vote!\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        Vote!\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 31 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" name=\"submit\" value=\"OptionA\" />\r\n");
#nullable restore
#line 34 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"col-sm-6\">\r\n");
#nullable restore
#line 37 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" name=\"submit\" value=\"OptionB\" />\r\n");
#nullable restore
#line 40 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d90ff5bc8626f22b42fb54ed1a2c7f84f20ea97f5563", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\wiece\Desktop\Sem6\BD\Program\Views\Home\VoteTopic.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bazadanych.Models.TopicModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
