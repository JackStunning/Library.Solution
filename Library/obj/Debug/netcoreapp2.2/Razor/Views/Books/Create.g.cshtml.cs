#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f9defefc7453670638185953686de30d2fd9d04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Create), @"mvc.1.0.view", @"/Views/Books/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Create.cshtml", typeof(AspNetCore.Views_Books_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f9defefc7453670638185953686de30d2fd9d04", @"/Views/Books/Create.cshtml")]
    public class Views_Books_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(60, 27, true);
            WriteLiteral("\r\n<h2>Add a new Book</h2>\r\n");
            EndContext();
#line 8 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(122, 34, false);
#line 10 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(163, 36, false);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(199, 6, true);
            WriteLiteral("<br>\r\n");
            EndContext();
            BeginContext(207, 65, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Add new Book\" />\r\n");
            EndContext();
#line 14 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
}

#line default
#line hidden
            BeginContext(275, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(279, 42, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\Library.Solution\Library\Views\Books\Create.cshtml"
Write(Html.ActionLink("Show all Books", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(321, 4, true);
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
