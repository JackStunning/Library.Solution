#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2887099eef753d97bc12d628862a23d4d41dbd9"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2887099eef753d97bc12d628862a23d4d41dbd9", @"/Views/Copys/Index.cshtml")]
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
            WriteLiteral("    <h3>No Copys have been taken yet!</h3>\r\n");
            EndContext();
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
}

#line default
#line hidden
            BeginContext(187, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
 foreach (Copy copy in Model)
{


#line default
#line hidden
            BeginContext(227, 18, true);
            WriteLiteral("    <li id=\"mark\">");
            EndContext();
            BeginContext(246, 85, false);
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
             Write(Html.ActionLink($"{ copy.CopyNumber }", "Details", "Copys", new { id = copy.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(331, 43, true);
            WriteLiteral("</li>\r\n    <p class=\"copyIndexP\">Due Date: ");
            EndContext();
            BeginContext(375, 16, false);
#line 20 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
                               Write(copy.CopyDueDate);

#line default
#line hidden
            EndContext();
            BeginContext(391, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
            
    //Need Book Name actionlink here that links back to the book that's clicked
    

#line default
#line hidden
            BeginContext(497, 74, false);
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink($"{ copy }", "Details", "Books", new { id = copy.BookId }));

#line default
#line hidden
            EndContext();
#line 23 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
                                                                               
}

#line default
#line hidden
            BeginContext(576, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(582, 42, false);
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Take new Copy", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(624, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(634, 54, false);
#line 27 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Back to Patrons", "Index", "Patrons"));

#line default
#line hidden
            EndContext();
            BeginContext(688, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(698, 40, false);
#line 28 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(738, 6, true);
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
