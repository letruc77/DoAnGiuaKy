#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "634c6319f161f44706e45b969e5e44d80ea2fc18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Revenue_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Revenue/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Revenue/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Revenue_Index))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
using WebApplication8.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"634c6319f161f44706e45b969e5e44d80ea2fc18", @"/Areas/Admin/Views/Revenue/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Revenue_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReportInfo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return checkvar()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(115, 56, true);
            WriteLiteral("\r\n<section class=\"content\">\r\n\r\n\r\n    <h2>Doanh số</h2>\r\n");
            EndContext();
#line 12 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
     if (ViewBag.FlagSearch!=null && ViewBag.FlagSearch)
    {


#line default
#line hidden
            BeginContext(238, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(246, 1055, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "412cfd0b6c5f43f58ae737318bf062fb", async() => {
                BeginContext(324, 123, true);
                WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                <select name=\"status\" class=\"form-control\">\r\n                    ");
                EndContext();
                BeginContext(447, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "105e7bf1d8504907926d4e78ab8976d1", async() => {
                    BeginContext(465, 21, true);
                    WriteLiteral("Đơn hàng chờ xác nhận");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(495, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(517, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ec5b4078f0d14b2e9d12dca86d64d6d3", async() => {
                    BeginContext(536, 15, true);
                    WriteLiteral("Đơn hàng đã xóa");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(560, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(582, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32733b84668e4b28861a314e8e92172d", async() => {
                    BeginContext(600, 17, true);
                    WriteLiteral("Đơn hàng đã duyệt");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(626, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(648, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f474deca029a43fda35367c193de7b0c", async() => {
                    BeginContext(666, 22, true);
                    WriteLiteral("Đơn hàng đã thanh toán");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(697, 316, true);
                WriteLiteral(@"
                </select>
            </div>
            <button style=""box-shadow: none;"" type=""submit"" class=""btn btn-primary btn-large"" name=""""><i class=""fa fa-search""></i> Tìm kiếm</button>
            <div class=""form-group"">
                <input type=""text"" class=""form-control datepk"" name=""datestart""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1013, "\"", 1039, 1);
#line 27 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
WriteAttributeValue("", 1021, ViewBag.datestart, 1021, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1040, 175, true);
                WriteLiteral(" placeholder=\"Từ ngày\">\r\n            </div>\r\n            -\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" class=\"form-control datepk\" name=\"dateend\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1215, "\"", 1239, 1);
#line 31 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
WriteAttributeValue("", 1223, ViewBag.dateend, 1223, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1240, 54, true);
                WriteLiteral(" placeholder=\"Đến ngày\">\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1301, 18, true);
            WriteLiteral("\r\n        <br />\r\n");
            EndContext();
#line 35 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(1328, 348, true);
            WriteLiteral(@"

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th>Group</th>
                <th>Số lượng</th>
                <th>Tổng</th>
                <th>Giá nhỏ nhất</th>
                <th>Giá lớn nhất</th>
                <th>Trung bình</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 51 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
            BeginContext(1730, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1803, 7, false);
#line 55 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(r.Group);

#line default
#line hidden
            EndContext();
            BeginContext(1810, 53, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>");
            EndContext();
            BeginContext(1864, 7, false);
#line 57 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(r.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1871, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1903, 32, false);
#line 58 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(Html.FormatValue(r.Sum, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(1935, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1967, 32, false);
#line 59 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(Html.FormatValue(r.Min, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(1999, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2031, 32, false);
#line 60 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(Html.FormatValue(r.Max, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(2063, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2095, 32, false);
#line 61 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                   Write(Html.FormatValue(r.Avg, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 63 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2172, 105, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n    <div id=\"piechart_3d\" style=\"height: 500px;\"></div>\r\n\r\n</section>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2294, 1342, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('.table').dataTable({
                ""dom"": 'RC<""clear"">lfrtip'
                //""dom"": 'Rlfrtip'

            });

        });
    </script>


    <script type=""text/javascript"">
        $('.datepk').datepicker({
            format: 'yyyy/mm/dd',
            // startDate: '-3d'
        });
    $(document).ready(function () {
        var table = $('.table').dataTable();
        var tt = new $.fn.dataTable.TableTools(table);
        $(tt.fnContainer()).insertBefore('div.dataTables_wrapper');
    });
    function checkvar() {
        console.log($(""[name='datestart']"").val());
        if ($(""[name='datestart']"").val() != '' && $(""[name='dateend']"").val() != '') {
            if ($(""[name='datestart']"").val() > $(""[name='dateend']"").val()) {
                alert(""Sai ngày chọn"");
                return false;
            }
        }
        return true;
    }
    </script>

    <script type=""text/javascrip");
                WriteLiteral(@"t"" src=""https://www.google.com/jsapi""></script>
    <script type=""text/javascript"">
    google.load(""visualization"", ""1"", { packages: [""corechart""] });
    google.setOnLoadCallback(drawChart);
    function drawChart() {
        var data = google.visualization.arrayToDataTable([
          ['Loai', 'Doanh so'],
");
                EndContext();
#line 113 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
           foreach (var r in Model)
          {
              

#line default
#line hidden
                BeginContext(3706, 2, true);
                WriteLiteral("[\"");
                EndContext();
                BeginContext(3709, 7, false);
#line 115 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                 Write(r.Group);

#line default
#line hidden
                EndContext();
                BeginContext(3716, 3, true);
                WriteLiteral("\", ");
                EndContext();
                BeginContext(3720, 33, false);
#line 115 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                            Write(r.Sum.ToString().Replace(",","."));

#line default
#line hidden
                EndContext();
                BeginContext(3753, 2, true);
                WriteLiteral("],");
                EndContext();
#line 115 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Revenue\Index.cshtml"
                                                                            
          }

#line default
#line hidden
                BeginContext(3777, 276, true);
                WriteLiteral(@"        ]);

        var options = {
            title: 'Biểu đồ thông tin',
            is3D: true,
        };

        var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
        chart.draw(data, options);
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReportInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
