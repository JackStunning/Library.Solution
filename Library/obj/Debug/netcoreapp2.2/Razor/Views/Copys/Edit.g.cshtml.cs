#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37823ad225027f0d0082fb9ec3b61455450791e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Copys_Edit), @"mvc.1.0.view", @"/Views/Copys/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Copys/Edit.cshtml", typeof(AspNetCore.Views_Copys_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37823ad225027f0d0082fb9ec3b61455450791e6", @"/Views/Copys/Edit.cshtml")]
    public class Views_Copys_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Copy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 39, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Edit this task: ");
            EndContext();
            BeginContext(100, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
               Write(Html.DisplayFor(model => model.CopyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(142, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(186, 37, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.HiddenFor(model => model.CopyId));

#line default
#line hidden
            EndContext();
            BeginContext(232, 40, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.LabelFor(model => model.CopyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(279, 41, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.EditorFor(model => model.CopyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(329, 25, false);
#line 18 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.Label("Select book"));

#line default
#line hidden
            EndContext();
            BeginContext(361, 27, false);
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.DropDownList("BookId"));

#line default
#line hidden
            EndContext();
            BeginContext(392, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(437, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(443, 40, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Edit.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(483, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Copy> Html { get; private set; }
    }
}
#pragma warning restore 1591
