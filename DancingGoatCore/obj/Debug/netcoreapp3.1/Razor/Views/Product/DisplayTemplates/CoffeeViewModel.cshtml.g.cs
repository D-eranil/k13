#pragma checksum "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a55a0a7b4b939f2bd171032f0fa4035dc805083"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DisplayTemplates_CoffeeViewModel), @"mvc.1.0.view", @"/Views/Product/DisplayTemplates/CoffeeViewModel.cshtml")]
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
#line 1 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using DancingGoat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using CMS.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.Content.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using Kentico.PageBuilder.Web.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a55a0a7b4b939f2bd171032f0fa4035dc805083", @"/Views/Product/DisplayTemplates/CoffeeViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88d8fa80da67568a3e522497460b5cdcd2065f73", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DisplayTemplates_CoffeeViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DancingGoat.Models.CoffeeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"product-detail-properties\">\r\n    <h4>");
#nullable restore
#line 4 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
   Write(HtmlLocalizer["Parameters"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 6 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(HtmlLocalizer["Farm"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 8 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                   Write(string.IsNullOrEmpty(Model.Farm) ? "-" : Model.Farm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 9 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(HtmlLocalizer["Variety"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 10 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                   Write(string.IsNullOrEmpty(Model.Variety) ? "-" : Model.Variety);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 11 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(HtmlLocalizer["Processing"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 12 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                   Write(string.IsNullOrEmpty(Model.Processing) ? "-" : Model.Processing);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 13 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(HtmlLocalizer["Altitude"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 14 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(Model.Altitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(" feet</dd>\r\n        <dt class=\"col-xs-12 col-sm-4\">");
#nullable restore
#line 15 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                  Write(HtmlLocalizer["Decaf"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n        <dd class=\"col-xs-12 col-sm-8\">");
#nullable restore
#line 16 "C:\inetpub\wwwroot\Kentico13Core\DancingGoatCore\Views\Product\DisplayTemplates\CoffeeViewModel.cshtml"
                                   Write(Model.IsDecaf ? HtmlLocalizer["Yes"] : HtmlLocalizer["No"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DancingGoat.Models.CoffeeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
