#pragma checksum "C:\WorkspaceGoldin\MyAcaWebsite\MyACAFrontEnd\MyACAWebsite\Views\Home\Notes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f540db7367b7e7bfe7636c75df35bdd118f6c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Notes), @"mvc.1.0.view", @"/Views/Home/Notes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Notes.cshtml", typeof(AspNetCore.Views_Home_Notes))]
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
#line 1 "C:\WorkspaceGoldin\MyAcaWebsite\MyACAFrontEnd\MyACAWebsite\Views\_ViewImports.cshtml"
using MyACAWebsite;

#line default
#line hidden
#line 2 "C:\WorkspaceGoldin\MyAcaWebsite\MyACAFrontEnd\MyACAWebsite\Views\_ViewImports.cshtml"
using MyACAWebsite.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f540db7367b7e7bfe7636c75df35bdd118f6c98", @"/Views/Home/Notes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95357a97a9dc8b1f4e3c01b576b8fe032ae01f50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Notes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\WorkspaceGoldin\MyAcaWebsite\MyACAFrontEnd\MyACAWebsite\Views\Home\Notes.cshtml"
  
    ViewData["Title"] = "Notes";

#line default
#line hidden
            BeginContext(43, 214, true);
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-9\">\r\n        <h2>Pin Board</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 257, "\"", 304, 1);
#line 11 "C:\WorkspaceGoldin\MyAcaWebsite\MyACAFrontEnd\MyACAWebsite\Views\Home\Notes.cshtml"
WriteAttributeValue("", 264, Url.Action("Dashboard_1", "Dashboards"), 264, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(305, 2721, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                App Views
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Pin Board</strong>
            </li>
        </ol>
    </div>
</div>

<div class=""wrapper wrapper-content animated fadeInUp"">
    <ul class=""notes"">
        <li>
            <div>
                <small>12:03:28 12-04-2014</small>
                <h4>Long established fact</h4>
                <p>The years, sometimes by accident, sometimes on purpose (injected humour and the like).</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>11:08:33 16-04-2014</small>
                <h4>Latin professor at Hampden-Sydney </h4>
                <p>The first line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>");
            WriteLiteral(@"
            </div>
        </li>
        <li>
            <div>
                <small>9:12:28 10-04-2014</small>
                <h4>The standard chunk of Lorem</h4>
                <p>Ipsum used since the 1500s is reproduced below for those interested.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>3:33:12 6-03-2014</small>
                <h4>The generated Lorem Ipsum </h4>
                <p>The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>5:20:11 4-04-2014</small>
                <h4>Contrary to popular belief</h4>
                <p>Hampden-Sydney College in Virginia, looked up one.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
     ");
            WriteLiteral(@"       </div>
        </li>
        <li>
            <div>
                <small>2:10:12 4-05-2014</small>
                <h4>There are many variations</h4>
                <p>All the Lorem Ipsum generators on the Internet .</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
        <li>
            <div>
                <small>10:15:26 6-04-2014</small>
                <h4>Ipsum used standard chunk of Lorem</h4>
                <p>Standard chunk  is reproduced below for those.</p>
                <a href=""#""><i class=""fa fa-trash-o ""></i></a>
            </div>
        </li>
    </ul>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
