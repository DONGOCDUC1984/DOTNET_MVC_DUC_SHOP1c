#pragma checksum "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e6806d08f92773547a9fa0d3f7bed047a925ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e6806d08f92773547a9fa0d3f7bed047a925ab", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55b14cb892f532e709593b1ecc5a538999a39785", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DOTNET_MVC_DUC_SHOP1c.Models.Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PDFFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning me-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\"> ");
#nullable restore
#line 8 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                      Write(localizer["Order"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n</div>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2e6806d08f92773547a9fa0d3f7bed047a925ab4586", async() => {
                WriteLiteral("\r\n            <i class=\"fa-solid fa-file-pdf\"></i> PDF File\r\n    ");
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
            WriteLiteral("\r\n</p>\r\n");
#nullable restore
#line 15 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
 if (Model != null && Model.Count > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
     foreach (var order in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>ID: ");
#nullable restore
#line 19 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
           Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <a onclick=\"return confirm(\'Are you sure that you really want to delete this ? \')\"");
            BeginWriteAttribute("href", "\r\n           href=\"", 600, "\"", 645, 2);
            WriteAttributeValue("", 619, "/Order/Delete?id=", 619, 17, true);
#nullable restore
#line 21 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
WriteAttributeValue("", 636, order.Id, 636, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger m-1\">\r\n            <i class=\"fa-solid fa-trash\"></i>\r\n            ");
#nullable restore
#line 23 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
       Write(localizer["Delete"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </a>\r\n        <p>\r\n            <b>");
#nullable restore
#line 26 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
          Write(localizer["At"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b>\r\n            ");
#nullable restore
#line 27 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
       Write(order.CreatedDate.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <b>");
#nullable restore
#line 30 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
          Write(localizer["Tel"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 30 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                                 Write(order.UserTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n        <p>\r\n            <b>");
#nullable restore
#line 33 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
          Write(localizer["Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(":</b> ");
#nullable restore
#line 33 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                                     Write(order.UserAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </p>\r\n");
            WriteLiteral("        <p>\r\n            <b>");
#nullable restore
#line 37 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
          Write(localizer["Details"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b>\r\n        </p>\r\n");
#nullable restore
#line 39 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
         if (order.OrderItems != null && order.OrderItems.Count > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table class=\"table table-bordered table-hover table-dark \r\n                    table-striped shadow mx-auto \">\r\n                <thead>\r\n                    <tr>\r\n                        <th> Id </th>\r\n                        <th> ");
#nullable restore
#line 46 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                        Write(localizer["Name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                        <th> ");
#nullable restore
#line 47 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                        Write(localizer["Price"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                        <th> ");
#nullable restore
#line 48 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                        Write(localizer["Quantity"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                        <th> ");
#nullable restore
#line 49 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                        Write(localizer["Sum"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 53 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                     foreach (var orderItem in order.OrderItems)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 57 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                           Write(orderItem.Product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                 ");
#nullable restore
#line 60 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                            Write(orderItem.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 63 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                           Write(orderItem.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 66 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                           Write(orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 69 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                            Write(orderItem.Product.Price * orderItem.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 72 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n            <p>\r\n                <b> ");
#nullable restore
#line 76 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
               Write(localizer["Total cost"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": </b> ");
#nullable restore
#line 76 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
                                              Write(order.totalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <hr />\r\n");
#nullable restore
#line 79 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
           
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\IT normal\C# Net\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\Version 2\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Order\Index.cshtml"
     
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DOTNET_MVC_DUC_SHOP1c.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591