#pragma checksum "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "181a610271d882258ed08db6dc4ea0ee3867eba1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__QuickAccessCardPartial), @"mvc.1.0.view", @"/Views/Shared/_QuickAccessCardPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_QuickAccessCardPartial.cshtml", typeof(AspNetCore.Views_Shared__QuickAccessCardPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"181a610271d882258ed08db6dc4ea0ee3867eba1", @"/Views/Shared/_QuickAccessCardPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176a77b76aa3b433adacbcf54b88aea6e1fca455", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__QuickAccessCardPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml"
  var address = "/Home/download/?fileDir=" + Model.Owner + "/" + Model.Name + "&fileName=" + Model.Name;

#line default
#line hidden
            BeginContext(125, 43, true);
            WriteLiteral("<div class=\"card clickable-file\" data-href=");
            EndContext();
            BeginContext(169, 7, false);
#line 3 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml"
                                      Write(address);

#line default
#line hidden
            EndContext();
            BeginContext(176, 261, true);
            WriteLiteral(@">
    <div id=""card-img"">
        <img class=""card-img""
             top width=""100%"" 
             src=""https://via.placeholder.com/1200x600"" 
             alt=""Card image cap""/>
        <i class=""fas fa-info-circle file-card-info""><a href=""#""></a></i>
");
            EndContext();
            BeginContext(518, 91, true);
            WriteLiteral("    </div>\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">\r\n            <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 609, "\"", 650, 3);
            WriteAttributeValue("", 617, "fas", 617, 3, true);
            WriteAttributeValue(" ", 620, "fa-", 621, 4, true);
#line 14 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml"
WriteAttributeValue("", 624, Model.FontAwesomeFileType, 624, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(651, 46, true);
            WriteLiteral("></span>\r\n            <span class=\"file-name\">");
            EndContext();
            BeginContext(698, 17, false);
#line 15 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml"
                               Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(715, 109, true);
            WriteLiteral("</span>\r\n        </h5>\r\n        <p class=\"card-text\"><small class=\"text-muted\">\r\n            Last edited by: ");
            EndContext();
            BeginContext(825, 11, false);
#line 18 "C:\Users\willi\source\repos\CSCI_3600_Group_Project\Views\Shared\_QuickAccessCardPartial.cshtml"
                       Write(Model.Owner);

#line default
#line hidden
            EndContext();
            BeginContext(836, 44, true);
            WriteLiteral("\r\n        </small></p>\r\n    </div>\r\n</div>\r\n");
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
