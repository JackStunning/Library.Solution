#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28850e723d67bd17318386db69b0356ed8c5cb39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Copys_Details), @"mvc.1.0.view", @"/Views/Copys/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Copys/Details.cshtml", typeof(AspNetCore.Views_Copys_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28850e723d67bd17318386db69b0356ed8c5cb39", @"/Views/Copys/Details.cshtml")]
    public class Views_Copys_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Copy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 37, true);
            WriteLiteral("\r\n<h2>Copy Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(98, 46, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
Write(Html.DisplayNameFor(model => model.CopyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(144, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(147, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
                                                Write(Html.DisplayFor(model => model.CopyNumber));

#line default
#line hidden
            EndContext();
            BeginContext(189, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
 if(@Model.Patrons.Count == 0)
{

#line default
#line hidden
            BeginContext(233, 51, true);
            WriteLiteral("  <p>This Copy does not belong to any Patrons</p>\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(296, 50, true);
            WriteLiteral("  <h4>Patrons the Copy has written:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
   foreach(var join in Model.Patrons)
  {

#line default
#line hidden
            BeginContext(390, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(399, 103, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
   Write(Html.ActionLink($"{ join.Patron.PatronName }", "Details", "Patrons", new { id = join.Patron.PatronId }));

#line default
#line hidden
            EndContext();
            BeginContext(502, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
     using (Html.BeginForm("DeletePatron", "Copys"))
    {
      

#line default
#line hidden
            BeginContext(577, 39, false);
#line 24 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
 Write(Html.Hidden("joinId", @join.CheckoutId));

#line default
#line hidden
            EndContext();
            BeginContext(618, 64, true);
            WriteLiteral("      <input id=\"detailsDelete\" type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
    }

#line default
#line hidden
#line 26 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
     
  }

#line default
#line hidden
            BeginContext(694, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 29 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
}

#line default
#line hidden
            BeginContext(706, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(712, 40, false);
#line 31 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(752, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(762, 71, false);
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
Write(Html.ActionLink("Add a Patron", "AddPatron", new { id = Model.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(833, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(843, 63, false);
#line 33 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
Write(Html.ActionLink("Edit Copy", "Edit", new { id = Model.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(916, 67, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Copys\Details.cshtml"
Write(Html.ActionLink("Delete Copy", "Delete", new { id = Model.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(983, 6, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Copy> Html { get; private set; }
    }
}
#pragma warning restore 1591
