#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18f9f10ea4e21a47468033efc39f3669e018338d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Inventorymanagement_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Inventorymanagement/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Inventorymanagement/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Inventorymanagement_Index))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
using WebApplication8.Areas.Admin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18f9f10ea4e21a47468033efc39f3669e018338d", @"/Areas/Admin/Views/Inventorymanagement/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Inventorymanagement_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ReportInfo>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(78, 380, true);
            WriteLiteral(@"



    <h2>Quản lý Kho</h2>
    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
                <th>Nhóm</th>
                <th>Số lượng</th>
                <th>Tổng</th>
                <th>Nhỏ nhât</th>
                <th>Lớn Nhất</th>
                <th>Trung bình</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 21 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
             foreach (var r in Model)
            {

#line default
#line hidden
            BeginContext(512, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(559, 7, false);
#line 24 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(r.Group);

#line default
#line hidden
            EndContext();
            BeginContext(566, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(598, 7, false);
#line 25 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(r.Count);

#line default
#line hidden
            EndContext();
            BeginContext(605, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(637, 32, false);
#line 26 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(Html.FormatValue(r.Sum, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(669, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(701, 32, false);
#line 27 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(Html.FormatValue(r.Min, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(733, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(765, 32, false);
#line 28 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(Html.FormatValue(r.Max, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(797, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(829, 32, false);
#line 29 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
                   Write(Html.FormatValue(r.Avg, "{0:c}"));

#line default
#line hidden
            EndContext();
            BeginContext(861, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Areas\Admin\Views\Inventorymanagement\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(906, 34, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(957, 543, true);
                WriteLiteral(@"

    <script>
        $(document).ready(function () {
            $('.table').dataTable({
                ""dom"": 'RC<""clear"">lfrtip'
               // ""dom"": 'Rlfrtip'
                
        });
           
            

            
        });
    </script>


<script type=""text/javascript"">
    $(document).ready(function () {
        var table = $('.table').dataTable();
        var tt = new $.fn.dataTable.TableTools(table);
        $(tt.fnContainer()).insertBefore('div.dataTables_wrapper');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ReportInfo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
