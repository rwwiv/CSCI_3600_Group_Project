#pragma checksum "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0074b842e76968f28bf4985515e3f3f5177dcf11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FileListItem), @"mvc.1.0.view", @"/Views/Shared/_FileListItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FileListItem.cshtml", typeof(AspNetCore.Views_Shared__FileListItem))]
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
#line 1 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\_ViewImports.cshtml"
using CSCI_3600_Group_Project;

#line default
#line hidden
#line 2 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\_ViewImports.cshtml"
using CSCI_3600_Group_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0074b842e76968f28bf4985515e3f3f5177dcf11", @"/Views/Shared/_FileListItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcb30626f0846377107f2654b6cdae6cfd61c3b4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FileListItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 28, true);
            WriteLiteral("\n<tr>\n    <td>\n        <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 45, "\"", 77, 4);
            WriteAttributeValue("", 53, "fas", 53, 3, true);
            WriteAttributeValue(" ", 56, "fa-{", 57, 5, true);
#line 5 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml"
WriteAttributeValue("", 61, Model.FileType, 61, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 76, "}", 76, 1, true);
            EndWriteAttribute();
            BeginContext(78, 14, true);
            WriteLiteral("></span>&emsp;");
            EndContext();
            BeginContext(93, 10, false);
#line 5 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(103, 19, true);
            WriteLiteral("\n    </td>\n    <td>");
            EndContext();
            BeginContext(123, 11, false);
#line 7 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml"
   Write(Model.Owner);

#line default
#line hidden
            EndContext();
            BeginContext(134, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(149, 18, false);
#line 8 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml"
   Write(Model.LastModified);

#line default
#line hidden
            EndContext();
            BeginContext(167, 14, true);
            WriteLiteral("</td>\n    <td>");
            EndContext();
            BeginContext(182, 10, false);
#line 9 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItem.cshtml"
   Write(Model.Size);

#line default
#line hidden
            EndContext();
            BeginContext(192, 11, true);
            WriteLiteral("</td>\n</tr>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FileModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
