#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aef6dd6aa2d7256ccf8f2f1f8a910a9377da27a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__Layout), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared__Layout))]
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
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
using WebApplication8.Models.UtilEntities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aef6dd6aa2d7256ccf8f2f1f8a910a9377da27a", @"/Areas/Admin/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("skin-blue sidebar-mini"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(70, 1297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19d6f606ec064ff8815b30d85989241d", async() => {
                BeginContext(76, 119, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>");
                EndContext();
                BeginContext(196, 13, false);
#line 7 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(209, 40, true);
                WriteLiteral(" - My ASP.NET MVC6 Application</title>\r\n");
                EndContext();
                BeginContext(417, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(422, 142, false);
#line 11 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.BoostrapValidatorCSS, Url.RouteUrl(new { controller = "/", area = "" }),Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(564, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(605, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(610, 132, false);
#line 13 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.LTE211CSS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(742, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(791, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(796, 125, false);
#line 15 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.Modernizr,Url.RouteUrl(new {controller="/",area="" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(921, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(962, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(967, 132, false);
#line 17 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.JTableCSS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(1099, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1367, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1369, 1685, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbbacf08cc64478b85a333b3599c5016", async() => {
                BeginContext(1406, 31, true);
                WriteLiteral("\r\n    <div class=\"wrapper\">\r\n\r\n");
                EndContext();
                BeginContext(1448, 43, false);
#line 25 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Header"));

#line default
#line hidden
                EndContext();
#line 25 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                      ;

#line default
#line hidden
                BeginContext(1495, 68, true);
                WriteLiteral("\r\n        <!-- Left side column. contains the logo and sidebar -->\r\n");
                EndContext();
                BeginContext(1574, 42, false);
#line 28 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Aside"));

#line default
#line hidden
                EndContext();
#line 28 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                     ; 

#line default
#line hidden
                BeginContext(1621, 145, true);
                WriteLiteral("\r\n        <!-- Content Wrapper. Contains page content -->\r\n\r\n        <div class=\"content-wrapper\">\r\n\r\n\r\n\r\n            <section class=\"content\">\r\n");
                EndContext();
#line 38 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                  await Html.RenderPartialAsync("_Alerts"); 

#line default
#line hidden
                BeginContext(1884, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1901, 12, false);
#line 39 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1913, 74, true);
                WriteLiteral("\r\n            </section>\r\n\r\n\r\n        </div><!-- /.content-wrapper -->\r\n\r\n");
                EndContext();
                BeginContext(1998, 43, false);
#line 45 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_Footer"));

#line default
#line hidden
                EndContext();
#line 45 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                      ;

#line default
#line hidden
                BeginContext(2045, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2058, 51, false);
#line 47 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
     Write(await Html.PartialAsync("Partials/_ControlSideBar"));

#line default
#line hidden
                EndContext();
#line 47 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
                                                              ;

#line default
#line hidden
                BeginContext(2113, 42, true);
                WriteLiteral("    </div><!-- ./wrapper -->\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                EndContext();
                BeginContext(2198, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2203, 131, false);
#line 56 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.LTE211JS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(2334, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2379, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2384, 131, false);
#line 58 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.JTableJS, Url.RouteUrl(new { controller = "/", area = "" }), Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(2515, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2572, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(2577, 142, false);
#line 60 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(Html.Raw(MybundleRegister.AddScript(MybundleRegister.BootstrapValidatorJS, Url.RouteUrl(new { controller = "/", area = "" }),Context.Request)));

#line default
#line hidden
                EndContext();
                BeginContext(2719, 86, true);
                WriteLiteral("\r\n    <script>\r\n    $.widget.bridge(\'uibutton\', $.ui.button);\r\n    </script>\r\n\r\n\r\n    ");
                EndContext();
                BeginContext(2806, 41, false);
#line 66 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\Shared\_Layout.cshtml"
Write(RenderSection("scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(2847, 200, true);
                WriteLiteral("\r\n\r\n    <script>\r\n    $(document).ready(function () {\r\n       // $(\"#id-alert\").fadeOut(6000);\r\n        // setTimeout(function () { $(\"#id-alert\").hide() }, 3000)\r\n    });\r\n\r\n\r\n\r\n    </script>\r\n\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3054, 13, true);
            WriteLiteral("\r\n\r\n\r\n</html>");
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