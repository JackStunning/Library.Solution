#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e88f2754d41f674d559694b8ae050ca0f2ae9678"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_AddBook), @"mvc.1.0.view", @"/Views/Authors/AddBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/AddBook.cshtml", typeof(AspNetCore.Views_Authors_AddBook))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e88f2754d41f674d559694b8ae050ca0f2ae9678", @"/Views/Authors/AddBook.cshtml")]
    public class Views_Authors_AddBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Author>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(62, 54, true);
            WriteLiteral("\r\n<h2>Add a book</h2>\r\n\r\n<h4>Add a book to this task: ");
            EndContext();
            BeginContext(117, 42, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
                        Write(Html.DisplayFor(model => model.AuthorName));

#line default
#line hidden
            EndContext();
            BeginContext(159, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(203, 39, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
Write(Html.HiddenFor(model => model.AuthorId));

#line default
#line hidden
            EndContext();
            BeginContext(251, 25, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
Write(Html.Label("Select book"));

#line default
#line hidden
            EndContext();
            BeginContext(283, 27, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
Write(Html.DropDownList("BookId"));

#line default
#line hidden
            EndContext();
            BeginContext(314, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
}

#line default
#line hidden
            BeginContext(359, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(365, 40, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Authors\AddBook.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(405, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591