#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b3a66a238abc39ce6d91895675048801208b4c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Copys_Index), @"mvc.1.0.view", @"/Views/Copys/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Copys/Index.cshtml", typeof(AspNetCore.Views_Copys_Index))]
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
#line 5 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b3a66a238abc39ce6d91895675048801208b4c3", @"/Views/Copys/Index.cshtml")]
    public class Views_Copys_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Models.Copy>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 20, true);
            WriteLiteral("\r\n<h2>Copys</h2>\r\n\r\n");
            EndContext();
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(140, 44, true);
            WriteLiteral("    <h3>No Copys have been added yet!</h3>\r\n");
            EndContext();
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(187, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
 foreach (Copy copy in Model)
{

#line default
#line hidden
            BeginContext(223, 18, true);
            WriteLiteral("    <li>\r\n        ");
            EndContext();
            BeginContext(242, 76, false);
#line 18 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
   Write(Html.ActionLink($"{ copy.CopyNumber }", "Details", new { id = copy.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(318, 49, true);
            WriteLiteral("\r\n    </li>\r\n    <p class=\"copyIndexP\">Due Date: ");
            EndContext();
            BeginContext(368, 16, false);
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
                               Write(copy.CopyDueDate);

#line default
#line hidden
            EndContext();
            BeginContext(384, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(393, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(399, 42, false);
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Take new Copy", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(441, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(451, 54, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Back to Patrons", "Index", "Patrons"));

#line default
#line hidden
            EndContext();
            BeginContext(505, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(515, 40, false);
#line 25 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(555, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Models.Copy>> Html { get; private set; }
    }
}
#pragma warning restore 1591
