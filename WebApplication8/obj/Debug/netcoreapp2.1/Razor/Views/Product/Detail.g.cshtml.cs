#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da1c69a961fee0a0c0a7f4968ce6fcce965afae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Detail), @"mvc.1.0.view", @"/Views/Product/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Detail.cshtml", typeof(AspNetCore.Views_Product_Detail))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da1c69a961fee0a0c0a7f4968ce6fcce965afae", @"/Views/Product/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication8.Models.WebShop.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:70px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
  
    ViewBag.Title = "Detail";

#line default
#line hidden
            BeginContext(85, 136, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 product\">\r\n        <div class=\"col-xs-12 col-sm-6 col-md-5 gallery-holder\">\r\n            ");
            EndContext();
            BeginContext(221, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "71e3ef82cc8447eb9b46cb5d5b59fb40", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 261, "~/Content/img/products/images/", 261, 30, true);
#line 9 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 291, Model.Image, 291, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 9 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 309, Model.Id, 309, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 205, true);
            WriteLiteral("\r\n\r\n\r\n        </div>\r\n        <div class=\"col-sm-6 col-md-7 product-info-block\">\r\n            <div class=\"single-product\">\r\n                <div class=\"product-info\">\r\n                    <h1 class=\"name\">");
            EndContext();
            BeginContext(526, 10, false);
#line 16 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(536, 1603, true);
            WriteLiteral(@"</h1>

                    <div class=""rating-reviews m-t-20"">
                        <div class=""row"">
                            <div class=""col-sm-3 hidden"">
                                <div class=""rating rateit-small rateit""><button id=""rateit-reset-5"" data-role=""none"" class=""rateit-reset"" aria-label=""reset rating"" aria-controls=""rateit-range-5"" style=""""></button>
                                <div id=""rateit-range-5"" class=""rateit-range"" tabindex=""0"" role=""slider"" aria-label=""rating"" aria-owns=""rateit-reset-5"" aria-valuemin=""0"" aria-valuemax=""5"" aria-valuenow=""0"" aria-readonly=""false"" style=""width: 80px; height: 16px;""><div class=""rateit-selected"" style=""height: 16px; width: 0px; display: block;""></div>
                                    <div class=""rateit-hover"" style=""height: 16px; width: 0px; display: none;""></div></div><button id=""rateit-reset-5"" data-role=""none"" class=""rateit-reset"" aria-label=""reset rating"" aria-controls=""rateit-range-5""></button><div id=""rateit-range-5"" class=""rate");
            WriteLiteral(@"it-range"" tabindex=""0"" role=""slider"" aria-label=""rating"" aria-owns=""rateit-reset-5"" aria-valuemin=""0"" aria-valuemax=""5"" aria-valuenow=""0"" aria-readonly=""false"" style=""width: 80px; height: 16px;""><div class=""rateit-selected"" style=""height: 16px; width: 0px; display: block;""></div><div class=""rateit-hover"" style=""height: 16px; width: 0px; display: none;""></div></div></div>
                            </div>
                            <div class=""col-sm-8"">
                                <div class=""reviews"">
                                    <a href=""#"" class=""lnk"">(");
            EndContext();
            BeginContext(2140, 11, false);
#line 27 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                        Write(Model.Views);

#line default
#line hidden
            EndContext();
            BeginContext(2151, 473, true);
            WriteLiteral(@" Reviews)</a>
                                </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.rating-reviews -->

                    <div class=""stock-container info-container m-t-10"">
                        <div class=""row"">
                            <div class=""col-sm-3"">
                                <div class=""stock-box"">
                                    <span class=""label"">");
            EndContext();
            BeginContext(2625, 22, false);
#line 37 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                   Write(Global["Availability"]);

#line default
#line hidden
            EndContext();
            BeginContext(2647, 195, true);
            WriteLiteral(":</span>\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-9\">\r\n                                <div class=\"stock-box\">\r\n");
            EndContext();
#line 42 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                     if (@Model.Available == true)
                                    {

#line default
#line hidden
            BeginContext(2949, 106, true);
            WriteLiteral("                                        <span class=\"text-bold\">\r\n                                        ");
            EndContext();
            BeginContext(3056, 17, false);
#line 45 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                   Write(Global["Instock"]);

#line default
#line hidden
            EndContext();
            BeginContext(3073, 51, true);
            WriteLiteral("\r\n                                        </span>\r\n");
            EndContext();
#line 47 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(3244, 106, true);
            WriteLiteral("                                        <span class=\"text-danger\">\r\n                                      ");
            EndContext();
            BeginContext(3351, 20, false);
#line 51 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                 Write(Global["NotInStock"]);

#line default
#line hidden
            EndContext();
            BeginContext(3371, 51, true);
            WriteLiteral("\r\n                                        </span>\r\n");
            EndContext();
#line 53 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3461, 266, true);
            WriteLiteral(@"
                                </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.stock-container -->

                    <div class=""description-container m-t-20"">
                      ");
            EndContext();
            BeginContext(3728, 28, false);
#line 61 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                 Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3756, 358, true);
            WriteLiteral(@"
                    </div><!-- /.description-container -->

                    <div class=""price-container info-container m-t-20"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <div class=""price-box"">
                                    <span class=""price numeral-init"">");
            EndContext();
            BeginContext(4164, 24, false);
#line 68 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                 Write((double)ViewBag.PriceOff);

#line default
#line hidden
            EndContext();
            BeginContext(4189, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 69 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                    if ((double)ViewBag.PriceOff != Model.PriceP)
                                   {

#line default
#line hidden
            BeginContext(4319, 76, true);
            WriteLiteral("                                    <span class=\"price-strike numeral-init\">");
            EndContext();
            BeginContext(4443, 12, false);
#line 71 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                      Write(Model.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(4455, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 72 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                   }

#line default
#line hidden
            BeginContext(4502, 400, true);
            WriteLiteral(@"                                      </div>
                            </div>
                        </div><!-- /.row -->
                    </div><!-- /.price-container -->

                    <div class=""quantity-container info-container"">
                        <div class=""row"">
                            <div class=""col-sm-2"">
                                <span class=""label"">");
            EndContext();
            BeginContext(4903, 17, false);
#line 81 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                               Write(Global["Quanity"]);

#line default
#line hidden
            EndContext();
            BeginContext(4920, 988, true);
            WriteLiteral(@" :</span>
                            </div>
                            <div class=""col-sm-2"">
                                <div class=""cart-quantity"">
                                    <div class=""quant-input"">
                                        <div class=""arrows"">
                                            <div class=""arrow plus gradient""><span class=""ir""><i class=""icon fa fa-sort-asc""></i></span></div>
                                            <div class=""arrow minus gradient""><span class=""ir""><i class=""icon fa fa-sort-desc""></i></span></div>
                                        </div>

                                        <input type=""text"" value=""1"" name=""soluong"" id=""soluong"">

                                    </div>
                                </div>
                            </div>

                            <div class=""col-sm-7"">
                                <a href=""#"" class=""btn btn-primary addProduct"" data-id=""");
            EndContext();
            BeginContext(5909, 8, false);
#line 98 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                   Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(5917, 20, true);
            WriteLiteral("\"  data-urladdcart=\"");
            EndContext();
            BeginContext(5938, 51, false);
#line 98 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                Write(Url.RouteUrl(new {controller="Cart",action="Add" }));

#line default
#line hidden
            EndContext();
            BeginContext(5989, 63, true);
            WriteLiteral("\"\r\n                                                 data-name=\"");
            EndContext();
            BeginContext(6053, 10, false);
#line 99 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(6063, 12, true);
            WriteLiteral("\" data-url=\"");
            EndContext();
            BeginContext(6076, 11, false);
#line 99 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                              Write(Model.Image);

#line default
#line hidden
            EndContext();
            BeginContext(6087, 23, true);
            WriteLiteral("\" data-urlpartialcart=\"");
            EndContext();
            BeginContext(6111, 65, false);
#line 99 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                                 Write(Url.RouteUrl(new { controller = "Cart", action = "PartialCart" }));

#line default
#line hidden
            EndContext();
            BeginContext(6176, 2120, true);
            WriteLiteral(@"""><i class=""fa fa-shopping-cart inner-right-vs""></i> Thêm vào giỏ</a>
                            </div>


                        </div><!-- /.row -->
                    </div><!-- /.quantity-container -->

                    <div class=""product-social-link m-t-20 text-right"">
                        <span class=""social-label"">Chia sẻ :</span>
                        <div class=""social-icons"">
                            <ul class=""list-inline"">
                                <li><a class=""fa fa-facebook"" href=""#""></a></li>
                                <li><a class=""fa fa-twitter"" href=""#""></a></li>
                                <li><a class=""fa fa-linkedin"" href=""#""></a></li>
                                <li><a class=""fa fa-rss"" href=""#""></a></li>
                                <li><a class=""fa fa-pinterest"" href=""#""></a></li>
                            </ul><!-- /.social-icons -->
                        </div>
                    </div>




                </div><!-- /.");
            WriteLiteral(@"product-info -->
            </div> <!--Single Product-->
        </div>

        <div class=""single-product outer-bottom-sm"">
           
         
            <div class=""product-tabs inner-bottom-xs"">
                <div class=""row"">
                    <div class=""col-sm-3"">
                        <ul id=""product-tabs"" class=""nav nav-tabs nav-tab-cell"">
                            <li class=""active""><a data-toggle=""tab"" href=""#description"">MÔ TẢ</a></li>
                            <li class=""hidden""><a data-toggle=""tab"" href=""#review"">REVIEW</a></li>
                            <li class=""hidden""><a data-toggle=""tab"" href=""#tags"">TAGS</a></li>
                        </ul><!-- /.nav-tabs #product-tabs -->
                    </div>
                    <div class=""col-sm-9"">

                        <div class=""tab-content"">

                            <div id=""description"" class=""tab-pane in active"">
                                <div class=""product-tab"">
                      ");
            WriteLiteral("              <p class=\"text\">\r\n                                        ");
            EndContext();
            BeginContext(8297, 28, false);
#line 145 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                   Write(Html.Raw(@Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(8325, 467, true);
            WriteLiteral(@"
                                    </p>
                                </div>
                            </div><!-- /.tab-pane -->

                        </div><!-- /.tab-content -->

                    </div><!-- /.col -->
                </div>

            </div>
        </div>


    </div>
 </div>
<div class=""row"">

    <section class=""section featured-product wow fadeInUp"">
        <h3 class=""section-title""> SẢN PHẨM ĐÃ XEM</h3>

");
            EndContext();
#line 166 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
         foreach (WebApplication8.Models.WebShop.Product m in ViewBag.Views)
        {

            var tukhoa = ViewBag.tukhoa;

#line default
#line hidden
            BeginContext(8925, 218, true);
            WriteLiteral("            <div class=\"products\" style=\"float:left\">\r\n\r\n                <div class=\"product\">\r\n                    <div class=\"product-image\">\r\n                        <div class=\"image\">\r\n                            ");
            EndContext();
            BeginContext(9143, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2034258909e34fb299d0b5c760677f0e", async() => {
                BeginContext(9194, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "84e321fa37ea4a07886d8edb44da4a2b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 9204, "~/Content/img/products/images/", 9204, 30, true);
#line 175 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 9234, m.Image, 9234, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 175 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 9299, m.Id, 9299, 5, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9152, "~/Product/Detail/", 9152, 17, true);
#line 175 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 9169, m.Id, 9169, 5, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 9174, "/", 9174, 1, true);
#line 175 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 9175, m.Name.ToAscii(), 9175, 17, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9310, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(9394, 306, true);
            WriteLiteral(@"                        </div><!-- /.image -->

                        <div class=""tag sale""><span>sale</span></div>
                    </div><!-- /.product-image -->


                    <div class=""product-info text-left"">
                        <h3 class=""name"">
                            ");
            EndContext();
            BeginContext(9700, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33d5a71757974305a2fbc4a3bd91252a", async() => {
                BeginContext(9733, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(9735, 6, false);
#line 187 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                         Write(m.Name);

#line default
#line hidden
                EndContext();
                BeginContext(9741, 3, true);
                WriteLiteral(";  ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9709, "~/Product/Detail/", 9709, 17, true);
#line 187 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
AddHtmlAttributeValue("", 9726, m.Id, 9726, 5, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9748, 296, true);
            WriteLiteral(@"

                        </h3>

                        <div class=""rating rateit-small""></div>
                        <div class=""description""></div>

                        <div class=""product-price"">
                            <span class=""price"">
                                ");
            EndContext();
            BeginContext(10045, 54, false);
#line 196 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                           Write(Html.FormatValue(m.PriceP * (1 - m.Discount), "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(10099, 106, true);
            WriteLiteral("\r\n\r\n                            </span>\r\n                            <span class=\"price-before-discount\"> ");
            EndContext();
            BeginContext(10206, 35, false);
#line 199 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                            Write(Html.FormatValue(m.PriceP, "{0:N}"));

#line default
#line hidden
            EndContext();
            BeginContext(10241, 466, true);
            WriteLiteral(@" </span>

                        </div><!-- /.product-price -->

                    </div><!-- /.product-info -->
                    <div class=""cart clearfix animate-effect"">
                        <div class=""action"">
                            <ul class=""list-unstyled"">
                                <li class=""add-cart-button btn-group"">
                                    <button class=""btn btn-primary icon addProduct"" type=""button"" data-id=""");
            EndContext();
            BeginContext(10708, 4, false);
#line 208 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                      Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10712, 230, true);
            WriteLiteral("\">\r\n                                        <i class=\"fa fa-shopping-cart\"></i>\r\n                                    </button>\r\n                                    <button class=\"btn btn-primary addProduct\" type=\"button\" data-id=\"");
            EndContext();
            BeginContext(10943, 4, false);
#line 211 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"
                                                                                                 Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(10947, 274, true);
            WriteLiteral(@""">Thêm vào giỏ</button>
                                </li>
                            </ul>
                        </div><!-- /.action -->
                    </div><!-- /.cart -->
                </div><!-- /.product -->

            </div><!-- /.products -->
");
            EndContext();
#line 219 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Product\Detail.cshtml"

        }

#line default
#line hidden
            BeginContext(11234, 60, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n    </section><!-- /.section -->\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public CustomerIdentity CustomerIdentity { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Global { get; private set; }
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
