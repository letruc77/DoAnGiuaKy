#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b46212ba15ecd9ede6a75b5176f8c0e7fa03716a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Products/Edit.cshtml", typeof(AspNetCore.Areas_Admin_Views_Products_Edit))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b46212ba15ecd9ede6a75b5176f8c0e7fa03716a", @"/Areas/Admin/Views/Products/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication8.Models.WebShop.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("PriceP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/maskedInput/jquery.maskedinput.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/setup_js_product_admin.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(87, 44, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Create Product</h4>\r\n");
            EndContext();
#line 11 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
 using (@Html.BeginForm("Update", "Products", FormMethod.Post, new { @class = "form-horizontal", role = "form", enctype = "multipart/form-data", id = "form-product-update" }))
{
    

#line default
#line hidden
            BeginContext(316, 50, false);
#line 13 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
Write(await Html.PartialAsync("Partials/_ErrorValidate"));

#line default
#line hidden
            EndContext();
            BeginContext(370, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(409, 67, false);
#line 16 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Id, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(476, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(523, 59, false);
#line 18 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Id, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(582, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(614, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(653, 69, false);
#line 23 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Name, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(722, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(769, 61, false);
#line 25 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(830, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(862, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(901, 71, false);
#line 30 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.PriceP, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(972, 34, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n");
            EndContext();
            BeginContext(1091, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1103, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f013ca2c1cf1442d8ffc5e3ef632a176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PriceP);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1162, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1202, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1241, 70, false);
#line 40 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Image, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 34, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n");
            EndContext();
            BeginContext(1402, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1415, 29, false);
#line 43 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1444, 149, true);
            WriteLiteral("\r\n            <input name=\"uplImage\" style=\"display:inline\" type=\"file\" id=\"btnSelectImg\" value=\"Choose Picture ...\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1595, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(1634, 76, false);
#line 49 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.ProductDate, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1710, 34, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n");
            EndContext();
            BeginContext(1831, 94, true);
            WriteLiteral("            <div class=\"input-group input-append date\" id=\"dateRangePicker\">\r\n                ");
            EndContext();
            BeginContext(1926, 68, false);
#line 53 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
           Write(Html.TextBoxFor(m => m.ProductDate, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1994, 164, true);
            WriteLiteral("\r\n                <span class=\"input-group-addon add-on\"><span class=\"glyphicon glyphicon-calendar\"></span></span>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2160, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2199, 75, false);
#line 60 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.CategoryId, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 34, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n");
            EndContext();
            BeginContext(2358, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2370, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6478327d8af143ab87aabf5b61e14b52", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 63 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 64 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CategoryId;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2460, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2492, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2531, 75, false);
#line 69 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.SupplierId, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2606, 34, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n");
            EndContext();
            BeginContext(2690, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2702, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6cf5d16803f4fb3a4723bd36aac608b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 72 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SupplierId);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 73 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.SupplierId;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2792, 74, true);
            WriteLiteral("\r\n            <input id=\"SupplierId-Text\" />\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2868, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(2907, 73, false);
#line 79 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Quantity, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(2980, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(3027, 65, false);
#line 81 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Quantity, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3092, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3124, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(3163, 73, false);
#line 86 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Discount, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(3236, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(3283, 65, false);
#line 88 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Discount, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(3348, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3380, 171, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        <label class=\"col-md-2 control-label\">Features</label>\r\n        <div class=\"col-md-8\">\r\n\r\n            <label class=\"checkbox-inline\">");
            EndContext();
            BeginContext(3552, 34, false);
#line 96 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                      Write(Html.CheckBoxFor(m => m.Available));

#line default
#line hidden
            EndContext();
            BeginContext(3586, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3588, 37, false);
#line 96 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                                                          Write(Html.DisplayNameFor(m => m.Available));

#line default
#line hidden
            EndContext();
            BeginContext(3625, 53, true);
            WriteLiteral("</label>\r\n            <label class=\"checkbox-inline\">");
            EndContext();
            BeginContext(3679, 32, false);
#line 97 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                      Write(Html.CheckBoxFor(m => m.Special));

#line default
#line hidden
            EndContext();
            BeginContext(3711, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3713, 35, false);
#line 97 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                                                        Write(Html.DisplayNameFor(m => m.Special));

#line default
#line hidden
            EndContext();
            BeginContext(3748, 53, true);
            WriteLiteral("</label>\r\n            <label class=\"checkbox-inline\">");
            EndContext();
            BeginContext(3802, 31, false);
#line 98 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                      Write(Html.CheckBoxFor(m => m.Latest));

#line default
#line hidden
            EndContext();
            BeginContext(3833, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3835, 34, false);
#line 98 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
                                                                       Write(Html.DisplayNameFor(m => m.Latest));

#line default
#line hidden
            EndContext();
            BeginContext(3869, 42, true);
            WriteLiteral("</label>\r\n\r\n\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(3913, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(3952, 70, false);
#line 105 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Views, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4022, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(4069, 62, false);
#line 107 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextBoxFor(m => m.Views, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(4131, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(4163, 38, true);
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
            EndContext();
            BeginContext(4202, 76, false);
#line 112 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
   Write(Html.LabelFor(m => m.Description, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(4278, 46, true);
            WriteLiteral("\r\n        <div class=\"col-md-8\">\r\n            ");
            EndContext();
            BeginContext(4325, 115, false);
#line 114 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
       Write(Html.TextAreaFor(m => m.Description, new { @class = "form-control ", rows = "3", cols = "55", id = "Description" }));

#line default
#line hidden
            EndContext();
            BeginContext(4440, 55, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <button type=\"submit\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4495, "\"", 4584, 3);
            WriteAttributeValue("", 4505, "form.action=\'", 4505, 13, true);
#line 117 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"
WriteAttributeValue("", 4518, Url.RouteUrl(new {controller="/",area="" }), 4518, 44, false);

#line default
#line hidden
            WriteAttributeValue("", 4562, "Admin/Products/Update\'", 4562, 22, true);
            EndWriteAttribute();
            BeginContext(4585, 133, true);
            WriteLiteral(" class=\"btn btn-primary box-button col-md-offset-2\">\r\n        Update\r\n        <i class=\"fa fa-check icon-white\"></i>\r\n    </button>\r\n");
            EndContext();
#line 121 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Products\Edit.cshtml"

}

#line default
#line hidden
            BeginContext(4723, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4746, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(4748, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17966883f73d4884ac4cc027c8d4e0cb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4815, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(4819, 54, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15ce9f1147234aff920e96ae1338a8b5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4873, 4009, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
    $(function () {
        // $('#datetimepicker1').datetimepicker();
        CKEDITOR.replace('Description');

    });
    </script>
    <script type=""text/javascript"">
        $(function () {
            var id = $(""#SupplierId"").val();
            $(""#SupplierId-Text"").val(id);
            $('#PriceP').mask(""000,000,000,000,000,000"", { reverse: true });
            $('#ProductDate').mask('99/99/9999');
            $(""#SupplierId"").change(function () {
                var id = $(this).val();
                $(""#SupplierId-Text"").val(id);
            });
        });
    </script>


    <script type=""text/javascript"">
    /*$(document).ready(function () {
        $(""#btnSelectImg"").click(function () {
            var finder = new CKFinder();
            finder.selectActionFunction = function (fileUrl) {
                $('#Image').val(fileUrl);
            };
            finder.popup();
        });
    });*/
    </script>

    <script typ");
                WriteLiteral(@"e=""text/javascript"">
    $(document).ready(function () {

        $('#dateRangePicker')
            .datepicker({
                format: 'dd/mm/yyyy',
                
            });

        $('#form-product-update').bootstrapValidator({
            //live: 'disabled',
            message: 'This value is not valid',
            feedbackIcons: {
                valid: 'glyphicon glyphicon-ok',
                invalid: 'glyphicon glyphicon-remove',
                validating: 'glyphicon glyphicon-refresh'
            },
            fields: {
                Name: {

                    validators: {
                        notEmpty: {
                            message: 'The Name is required and cannot be empty'
                        },


                    }
                },

                UnitPrice: {

                    validators: {
                        notEmpty: {
                            message: 'The Unit Price is required and cannot be empty'
         ");
                WriteLiteral(@"               },


                    }
                },

                Image: {

                    validators: {
                        notEmpty: {
                            message: 'The Image is required and cannot be empty'
                        },


                    }
                },


                ProductDate: {

                    validators: {
                        notEmpty: {
                            message: 'The Product Date is required and cannot be empty'
                        },
                        date: {
                            format: 'DD/MM/YYYY',
                            message: 'in valid date time. format The dd/mm/yyyy'
                        },


                    }
                },

                Quantity: {

                    validators: {
                        notEmpty: {
                            message: 'The Quantity is required and cannot be empty'
                        },


         ");
                WriteLiteral(@"           }
                },

                Discount: {

                    validators: {
                        notEmpty: {
                            message: 'The Discount is required and cannot be empty'
                        },


                    }
                },

                View: {

                    validators: {
                        notEmpty: {
                            message: 'The View is required and cannot be empty'
                        },


                    }
                },


            }
        });

        // Validate the form manually
        //$('#validateBtn').click(function() {
        //    $('#RegisterForm').bootstrapValidator('validate');
        //});

        //$('#resetBtn').click(function() {
        //    $('#defaultForm').data('bootstrapValidator').resetForm(true);
        //});
    });



    </script>





");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication8.Models.WebShop.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
