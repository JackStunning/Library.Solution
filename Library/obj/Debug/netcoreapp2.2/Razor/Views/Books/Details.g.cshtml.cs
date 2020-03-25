#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08546c76a97149eea209246c5f92d860536507c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Details.cshtml", typeof(AspNetCore.Views_Books_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08546c76a97149eea209246c5f92d860536507c2", @"/Views/Books/Details.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 37, true);
            WriteLiteral("\r\n<h2>Book Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(99, 10, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(109, 9, true);
            WriteLiteral("</h3>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
 if(@Model.Authors.Count == 0)
{

#line default
#line hidden
            BeginContext(153, 61, true);
            WriteLiteral("  <p>This book does not have any authors. Who wrote it?</p>\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(226, 41, true);
            WriteLiteral("  <h4>Authors of the book:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
   foreach(var join in Model.Authors)
  {

#line default
#line hidden
            BeginContext(311, 18, true);
            WriteLiteral("    <li id=\"mark\">");
            EndContext();
            BeginContext(330, 103, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
             Write(Html.ActionLink($"{ join.Author.AuthorName }", "Details", "Authors", new { id = join.Author.AuthorId }));

#line default
#line hidden
            EndContext();
            BeginContext(433, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(445, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
            BeginContext(456, 34, true);
            WriteLiteral("  <h4>Copys rented:</h4>\r\n  <ul>\r\n");
            EndContext();
#line 27 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
   foreach(var join in Model.Copys)
  {

#line default
#line hidden
            BeginContext(532, 18, true);
            WriteLiteral("    <li id=\"mark\">");
            EndContext();
            BeginContext(551, 95, false);
#line 29 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
             Write(Html.ActionLink($"{ join.Copy.CopyNumber }", "Details", "Copys", new { id = join.Copy.CopyId }));

#line default
#line hidden
            EndContext();
            BeginContext(646, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 30 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
  }

#line default
#line hidden
            BeginContext(658, 9, true);
            WriteLiteral("  </ul>\r\n");
            EndContext();
#line 32 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
}

#line default
#line hidden
            BeginContext(670, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(676, 53, false);
#line 34 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Checkout Book?", "Index", "Patrons"));

#line default
#line hidden
            EndContext();
            BeginContext(729, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(739, 41, false);
#line 35 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Back to Books", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(780, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(790, 63, false);
#line 36 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Edit Book", "Edit", new { id = Model.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(853, 9, true);
            WriteLiteral("</p>\r\n<p>");
            EndContext();
            BeginContext(863, 67, false);
#line 37 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Delete Book", "Delete", new { id = Model.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(930, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
