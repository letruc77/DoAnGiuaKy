#pragma checksum "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd88c183307d0dc67bd8ee135740ba5708ce195e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_QuanLy_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/QuanLy/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/QuanLy/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_QuanLy_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd88c183307d0dc67bd8ee135740ba5708ce195e", @"/Areas/Admin/Views/QuanLy/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2dbf9650d50b49d3e3ce7a646256dc19e70a1", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_QuanLy_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/Admin/LTE/211/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Template/Admin/LTE/211/dist/js/pages/dashboard.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
  
   // WebApplication8.Areas.Admin.Models.DataChart;
    var list_data = (List<WebApplication8.Areas.Admin.Models.DataChart>)ViewBag.DataChart;

#line default
#line hidden
            BeginContext(274, 523, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>Trang quản lý <small>Control panel</small></h1>
    <ol class=""breadcrumb"">
        <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
        <li class=""active"">Dashboard</li>
    </ol>
</section>
<section class=""content"">
    <!-- Small boxes (Stat box) -->
    <div class=""row"">
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-aqua"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(798, 14, false);
#line 22 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
                   Write(ViewBag.Orders);

#line default
#line hidden
            EndContext();
            BeginContext(812, 532, true);
            WriteLiteral(@"</h3>
                    <p>New Orders</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-bag""></i>
                </div>
                <a href=""/admin/order"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div><!-- ./col -->

        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-yellow"">
                <div class=""inner"">
                    <h3>");
            EndContext();
            BeginContext(1345, 13, false);
#line 36 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
                   Write(ViewBag.Users);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 1096, true);
            WriteLiteral(@"</h3>
                    <p>User Registrations</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person-add""></i>
                </div>
                <a href=""/admin/customers"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div><!-- ./col -->
        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box bg-red"">
                <div class=""inner"">
                    <h3>Revenue</h3>
                    <p>Revenue</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""/Admin/Revenue/ByYear"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div><!-- ./col -->

        <div class=""col-lg-3 col-xs-6"">
            <!-- small box -->
            <div class=""small-box b");
            WriteLiteral("g-green\">\r\n                <div class=\"inner\">\r\n                    <h3>");
            EndContext();
            BeginContext(2455, 15, false);
#line 63 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
                   Write(ViewBag.Product);

#line default
#line hidden
            EndContext();
            BeginContext(2470, 1100, true);
            WriteLiteral(@"</h3>
                    <p>Product</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""/Admin/Products"" class=""small-box-footer"">More info <i class=""fa fa-arrow-circle-right""></i></a>
            </div>
        </div><!-- ./col -->
    </div><!-- /.row -->
    <!-- Main row -->

    <div class=""row"">
        <section class=""col-lg-6 connectedSortable "">
            <!-- quick email widget -->
            <div class=""box box-info"">
                <div class=""box-header"">
                    <i class=""fa fa-envelope""></i>
                    <h3 class=""box-title"">Quick Email</h3>
                    <!-- tools box -->
                    <div class=""pull-right box-tools"">
                        <button class=""btn btn-info btn-sm"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove""><i class=""fa fa-times""></i></button>
                    </div><!-- /. tools -->
        ");
            WriteLiteral("        </div>\r\n                <div class=\"box-body\">\r\n                    ");
            EndContext();
            BeginContext(3570, 712, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f0a7523680c45798cff74d9c469d918", async() => {
                BeginContext(3601, 674, true);
                WriteLiteral(@"
                        <div class=""form-group"">
                            <input type=""email"" class=""form-control"" name=""emailto"" placeholder=""Email to:"" />
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" class=""form-control"" name=""subject"" placeholder=""Subject"" />
                        </div>
                        <div>
                            <textarea class=""textarea"" placeholder=""Message"" style=""width: 100%; height: 125px; font-size: 14px; line-height: 18px; border: 1px solid #dddddd; padding: 10px;""></textarea>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4282, 1395, true);
            WriteLiteral(@"
                </div>
                <div class=""box-footer clearfix"">
                    <button class=""pull-right btn btn-default"" id=""sendEmail"">Send <i class=""fa fa-arrow-circle-right""></i></button>
                </div>
            </div>
        </section>
        <section class=""col-lg-6 connectedSortable"">
            <!-- solid sales graph -->
            <div class=""box box-solid bg-teal-gradient"">
                <div class=""box-header"">
                    <i class=""fa fa-th""></i>
                    <h3 class=""box-title"">Biểu đồ doanh số bán hàng</h3>
                    <div class=""box-tools pull-right"">
                        <button class=""btn bg-teal btn-sm"" data-widget=""collapse""><i class=""fa fa-minus""></i></button>
                        <button class=""btn bg-teal btn-sm"" data-widget=""remove""><i class=""fa fa-times""></i></button>
                    </div>
                </div>
                <div class=""box-body border-radius-none "">
                    <div clas");
            WriteLiteral(@"s=""chart"" id=""line-chart"" style=""height: 250px;""></div>
                </div><!-- /.box-body -->
                <div class=""box-footer no-border"">
                    <p style=""color:#c5c0c0""><i>(&lowast;)Số liệu 12 tháng gần đây</i></p>
                </div><!-- /.box-footer -->
            </div><!-- /.box -->
        </section>
    </div>


</section>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5694, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
                BeginContext(5702, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b33415b1cfb2462d9dcc73097a9da9e6", async() => {
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
                BeginContext(5810, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(5812, 75, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5f73ed0df394a6a9380806cc3348f6a", async() => {
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
                BeginContext(5887, 162, true);
                WriteLiteral("\r\n\r\n    <script type=\"text/javascript\">\r\n       var line = new Morris.Line({\r\n            element: \'line-chart\',\r\n            resize: true,\r\n            data: [\r\n");
                EndContext();
#line 138 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
                 foreach (var i in list_data) {
                    

#line default
#line hidden
                BeginContext(6119, 52, false);
#line 139 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
               Write(Html.Raw("{y:'"+i.Label + "',item1:"+i.Value + "},"));

#line default
#line hidden
                EndContext();
#line 139 "D:\CodeMua\WebShop-MVC6-Core-2.1\WebApplication8\WebApplication8\Areas\Admin\Views\QuanLy\Index.cshtml"
                                                                         ;
                   // { y: '2017-01', item1: 2666 },
                 }

#line default
#line hidden
                BeginContext(6248, 1697, true);
                WriteLiteral(@"                
              /*{ y: '2017-02', item1: 2778 },
              { y: '2017-03', item1: 4912 },
              { y: '2017-04', item1: 3767 },
              { y: '2017-05', item1: 2666 },
              { y: '2017-06', item1: 2778 },
              { y: '2017-07', item1: 4912 },
              { y: '2017-08', item1: 3767 },
               { y: '2017-09', item1: 2666 },
              { y: '2017-10', item1: 2778 },
              { y: '2017-11', item1: 4912 },
              { y: '2017-12', item1: 3767 },
              /* { y: '2017 Q1', item1: 2666 },
              { y: '2017 Q2', item1: 2778 },
              { y: '2017 Q3', item1: 4912 },
              { y: '2017 Q4', item1: 3767 },
             // { y: '2017 May', item1: 6810 },
             /* { y: '2017 6', item1: 5670 },
              { y: '2017 7', item1: 4820 },
              { y: '2017 8', item1: 15073 },
              { y: '2017 9', item1: 10687 },
              { y: '2017 10', item1: 8432 },
              { y: '2017 11', i");
                WriteLiteral(@"tem1: 8432 },
              { y: '2017 12', item1: 8432 }*/
            ],
            //xLabelFormat: function (x) { return x.toString() +""""; },
            //xLabels: ""day"",
            xkey: 'y',
            ykeys: ['item1'],
            labels: ['Doanh số'],
            lineColors: ['#efefef'],
            // lineWidth: 2,
            //  hideHover: 'auto',
            gridTextColor: ""#fff"",
            //  gridStrokeWidth: 0.4,
            // pointSize: 4,
            // pointStrokeColors: [""#efefef""],
            gridLineColor: ""#efefef"",
            gridTextFamily: ""Open Sans"",
            gridTextSize: 10
        });

    </script>


");
                EndContext();
            }
            );
            BeginContext(7948, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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