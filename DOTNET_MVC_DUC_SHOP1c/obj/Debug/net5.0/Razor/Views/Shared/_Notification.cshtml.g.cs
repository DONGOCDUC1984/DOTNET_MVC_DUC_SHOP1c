#pragma checksum "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "feee6ae6226efc6d5b22bc69aa819737354b9d957d0b77c0b2ccce4a12f62de3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Notification), @"mvc.1.0.view", @"/Views/Shared/_Notification.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\_ViewImports.cshtml"
using DOTNET_MVC_DUC_SHOP1c;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\_ViewImports.cshtml"
using DOTNET_MVC_DUC_SHOP1c.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"feee6ae6226efc6d5b22bc69aa819737354b9d957d0b77c0b2ccce4a12f62de3", @"/Views/Shared/_Notification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"4816ea585cc9480d19dbd383eb5e0af8912c8fc361e4020f4f8d9d7a2880b436", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Notification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feee6ae6226efc6d5b22bc69aa819737354b9d957d0b77c0b2ccce4a12f62de33761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t<script src=\"https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js\"></script>\r\n");
#nullable restore
#line 4 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml"
	if (TempData["success"] != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<script type=\"text/javascript\">\r\n\t\t\ttoastr.success(\"");
#nullable restore
#line 7 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml"
                       Write(TempData["success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\t\t</script>\r\n");
#nullable restore
#line 9 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml"
	}

	if (TempData["error"] != null)
	{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<script type=\"text/javascript\">\r\n\t\t\ttoastr.error(\"");
#nullable restore
#line 14 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml"
                     Write(TempData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\");\r\n\t\t</script>\r\n");
#nullable restore
#line 16 "D:\IT normal\C#\Projects\MVC\DOTNET_MVC_DUC_SHOP1c\DOTNET_MVC_DUC_SHOP1c\Views\Shared\_Notification.cshtml"
	}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
