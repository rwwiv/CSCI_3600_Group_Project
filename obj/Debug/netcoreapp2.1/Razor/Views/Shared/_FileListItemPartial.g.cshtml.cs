#pragma checksum "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cb4b001ed3baa67cb8fe95281dee4896e2fefe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FileListItemPartial), @"mvc.1.0.view", @"/Views/Shared/_FileListItemPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_FileListItemPartial.cshtml", typeof(AspNetCore.Views_Shared__FileListItemPartial))]
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
#line 1 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\_ViewImports.cshtml"
using CSCI_3600_Group_Project;

#line default
#line hidden
#line 2 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\_ViewImports.cshtml"
using CSCI_3600_Group_Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cb4b001ed3baa67cb8fe95281dee4896e2fefe", @"/Views/Shared/_FileListItemPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"176a77b76aa3b433adacbcf54b88aea6e1fca455", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FileListItemPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FileModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary view"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
  
    string[] sizes = {"KB","KB", "MB", "GB"};
    int pos = 0;
    double fileSize = Model.Size;
    while (fileSize > (1024 * pos))
    {
        fileSize = fileSize / 1024;
        pos++;
    }
    fileSize = Math.Ceiling(fileSize);
    string modelName = Model.Name.Replace(" ", "%20");
    var address = "/Home/download/?fileName=" + modelName;

#line default
#line hidden
            BeginContext(385, 39, true);
            WriteLiteral("\r\n<tr class=\"clickable-file\" data-href=");
            EndContext();
            BeginContext(425, 7, false);
#line 16 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                                Write(address);

#line default
#line hidden
            EndContext();
            BeginContext(432, 41, true);
            WriteLiteral(">\r\n    <td class=\"file-text\">\r\n        <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 473, "\"", 514, 3);
            WriteAttributeValue("", 481, "fas", 481, 3, true);
            WriteAttributeValue(" ", 484, "fa-", 485, 4, true);
#line 18 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
WriteAttributeValue("", 488, Model.FontAwesomeFileType, 488, 26, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(515, 45, true);
            WriteLiteral("></i>&emsp;\r\n        <span class=\"file-name\">");
            EndContext();
            BeginContext(561, 17, false);
#line 19 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                           Write(Model.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(578, 46, true);
            WriteLiteral("</span>\r\n    </td>\r\n    <td class=\"file-text\">");
            EndContext();
            BeginContext(625, 11, false);
#line 21 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                     Write(Model.Owner);

#line default
#line hidden
            EndContext();
            BeginContext(636, 33, true);
            WriteLiteral("</td>\r\n    <td class=\"file-text\">");
            EndContext();
            BeginContext(670, 18, false);
#line 22 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                     Write(Model.LastModified);

#line default
#line hidden
            EndContext();
            BeginContext(688, 33, true);
            WriteLiteral("</td>\r\n    <td class=\"file-text\">");
            EndContext();
            BeginContext(722, 8, false);
#line 23 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                     Write(fileSize);

#line default
#line hidden
            EndContext();
            BeginContext(730, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(732, 10, false);
#line 23 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                               Write(sizes[pos]);

#line default
#line hidden
            EndContext();
            BeginContext(742, 17, true);
            WriteLiteral("</td>\r\n    <td>\r\n");
            EndContext();
            BeginContext(861, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(869, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5516fce7bb434b98be38ddec3c232428", async() => {
                BeginContext(997, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-fileName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
                                                                                              WriteLiteral(Model.Name);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fileName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-fileName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["fileName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 50, true);
            WriteLiteral("\r\n        <button class=\"btn btn-secondary delete\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 1055, "\"", 1090, 3);
            WriteAttributeValue("", 1065, "deleteLoad(\'", 1065, 12, true);
#line 27 "C:\Users\rwernert\source\repos\CSCI_3600_Group_Project\Views\Shared\_FileListItemPartial.cshtml"
WriteAttributeValue("", 1077, Model.Name, 1077, 11, false);

#line default
#line hidden
            WriteAttributeValue("", 1088, "\')", 1088, 2, true);
            EndWriteAttribute();
            BeginContext(1091, 36, true);
            WriteLiteral(">Delete</button>\r\n    </td>\r\n</tr>\r\n");
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
