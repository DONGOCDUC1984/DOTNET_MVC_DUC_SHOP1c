#pragma checksum "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c012c868ad392b6aa139f825535a17990cdd8c82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_District_Index), @"mvc.1.0.view", @"/Views/District/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c012c868ad392b6aa139f825535a17990cdd8c82", @"/Views/District/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b14cb892f532e709593b1ecc5a538999a39785", @"/Views/_ViewImports.cshtml")]
    public class Views_District_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DOTNET_MVC_DUC_SHOP1c.Models.District>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUpdate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure that you really want to delete this ? \')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
  
    ViewData["Title"] = "District";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> ");
#nullable restore
#line 8 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                      Write(localizer["District"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n</div>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c012c868ad392b6aa139f825535a17990cdd8c825681", async() => {
                WriteLiteral("\r\n        <i class=\"fa-solid fa-plus\"></i> ");
#nullable restore
#line 12 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                                    Write(localizer["Create New"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n");
#nullable restore
#line 16 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
 if (Model != null &&  Model.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-hover mx-auto w-50\">\r\n        <thead>\r\n            <tr>\r\n                <th> Id </th>\r\n                <th> ");
#nullable restore
#line 22 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                Write(localizer["District"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 23 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                Write(localizer["Province/City"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                <th> ");
#nullable restore
#line 24 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                Write(localizer["Actions"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 28 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 35 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                   Write(item.ProvinceCityName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c012c868ad392b6aa139f825535a17990cdd8c8210315", async() => {
                WriteLiteral("\r\n                            <i class=\"fa-solid fa-pen-to-square\"></i> ");
#nullable restore
#line 43 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                                                                 Write(localizer["Edit"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
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
#line 42 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                                                    WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c012c868ad392b6aa139f825535a17990cdd8c8213085", async() => {
                WriteLiteral("\r\n                            <i class=\"fa-solid fa-trash\"></i> ");
#nullable restore
#line 47 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                                                         Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
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
#line 46 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
                                                 WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 51 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 54 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\District\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DOTNET_MVC_DUC_SHOP1c.Models.District>> Html { get; private set; }
    }
}
#pragma warning restore 1591
