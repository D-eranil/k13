#pragma checksum "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84e6cbef75fd82917fa5bd5931c201361eff6bf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Components_InlineEditors_SpinnerEditor__SpinnerEditor), @"mvc.1.0.view", @"/Components/InlineEditors/SpinnerEditor/_SpinnerEditor.cshtml")]
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
#nullable restore
#line 1 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84e6cbef75fd82917fa5bd5931c201361eff6bf3", @"/Components/InlineEditors/SpinnerEditor/_SpinnerEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3dd21c4f465e83903a12d676a1dd0c01e2783b2", @"/Components/_ViewImports.cshtml")]
    public class Components_InlineEditors_SpinnerEditor__SpinnerEditor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.InlineEditors.SpinnerEditorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml"
 using (Html.Kentico().BeginInlineEditor("spinner-editor", Model.PropertyName, new { @class = "spinner-editor" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"inline-editor-btn-group\">\r\n        <ul class=\"inline-editor-btn-group-actions\">\r\n            <li><button id=\"minus-btn\" type=\"button\"");
            BeginWriteAttribute("title", " title=\"", 327, "\"", 388, 1);
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml"
WriteAttributeValue("", 335, HtmlLocalizer["Decrease number of displayed items."], 335, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>-</b></button></li>\r\n            <li><button id=\"value-btn\" type=\"button\" disabled><b id=\"value-placeholder\">");
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml"
                                                                                   Write(Model.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></button></li>\r\n            <li><button id=\"plus-btn\" type=\"button\"");
            BeginWriteAttribute("title", " title=\"", 585, "\"", 646, 1);
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml"
WriteAttributeValue("", 593, HtmlLocalizer["Increase number of displayed items."], 593, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>+</b></button></li>\r\n        </ul>\r\n    </div>\r\n");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Components\InlineEditors\SpinnerEditor\_SpinnerEditor.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlLocalizer<SharedResources> HtmlLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.InlineEditors.SpinnerEditorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
