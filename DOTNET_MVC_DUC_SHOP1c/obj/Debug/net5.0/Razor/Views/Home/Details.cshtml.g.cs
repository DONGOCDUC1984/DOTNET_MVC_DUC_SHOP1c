#pragma checksum "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88df1996d047040e2c239cb4a5969dc283cbc186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\_ViewImports.cshtml"
using DOTNET_MVC_DUC_SHOP1c;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\_ViewImports.cshtml"
using DOTNET_MVC_DUC_SHOP1c.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88df1996d047040e2c239cb4a5969dc283cbc186", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b14cb892f532e709593b1ecc5a538999a39785", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOTNET_MVC_DUC_SHOP1c.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure that you really want to delete this ? \')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 3 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 8 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
                     Write(localizer["Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n    \r\n</div>\r\n\r\n<div>\r\n\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            Id\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Description"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            $ ");
#nullable restore
#line 38 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
         Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Category"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Province/City"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.District.ProvinceCity.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["District"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(Html.DisplayFor(model => model.District.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
       Write(localizer["Image"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <img class=\"card-img-top my-1 mx-auto\"");
            BeginWriteAttribute("src", "\r\n                 src=\"", 1758, "\"", 1797, 1);
#nullable restore
#line 63 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
WriteAttributeValue("", 1782, Model.ImageUrl, 1782, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                 alt=\"Card image\"\r\n                 style=\"width:14rem ;height: 8rem\">\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 70 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
     if (User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88df1996d047040e2c239cb4a5969dc283cbc18612538", async() => {
                WriteLiteral("\r\n            <i class=\"fa-solid fa-pen-to-square\"></i> ");
#nullable restore
#line 73 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
                                                 Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
                                    WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88df1996d047040e2c239cb4a5969dc283cbc18615225", async() => {
                WriteLiteral("\r\n            <i class=\"fa-solid fa-trash\"></i> ");
#nullable restore
#line 77 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
                                         Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 79 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88df1996d047040e2c239cb4a5969dc283cbc18618216", async() => {
                WriteLiteral("\r\n        <i class=\"fa-solid fa-backward\"></i> ");
#nullable restore
#line 82 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Home\Details.cshtml"
                                        Write(localizer["Back to home"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Mvc.Localization.IViewLocalizer localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOTNET_MVC_DUC_SHOP1c.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
