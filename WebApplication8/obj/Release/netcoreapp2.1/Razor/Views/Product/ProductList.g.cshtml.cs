#pragma checksum "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5944638e4fc7171b10a8bac3e604c557c63bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductList), @"mvc.1.0.view", @"/Views/Product/ProductList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ProductList.cshtml", typeof(AspNetCore.Views_Product_ProductList))]
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
#line 1 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8;

#line default
#line hidden
#line 2 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models;

#line default
#line hidden
#line 3 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.AccountViewModels;

#line default
#line hidden
#line 4 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.ManageViewModels;

#line default
#line hidden
#line 5 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 7 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#line 8 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\_ViewImports.cshtml"
using WebApplication8.Models.IdentityModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5944638e4fc7171b10a8bac3e604c557c63bbe", @"/Views/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sakura.AspNetCore.IPagedList<WebApplication8.Models.WebShop.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
  
    ViewBag.Title = "Product";

#line default
#line hidden
            BeginContext(118, 215, true);
            WriteLiteral("\r\n\r\n\r\n<!-- ============================================== FEATURED PRODUCTS ============================================== -->\r\n<section class=\"section featured-product wow fadeInUp\">\r\n    <h3 class=\"section-title\">");
            EndContext();
            BeginContext(334, 21, false);
#line 11 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                         Write(Global["ProductList"]);

#line default
#line hidden
            EndContext();
            BeginContext(355, 89, true);
            WriteLiteral("</h3>\r\n\r\n    <div id=\"contentPagerList\" class=\"pull-right\" style=\"padding-right:40px;\">\r\n");
            EndContext();
            BeginContext(549, 14, true);
            WriteLiteral("        Trang ");
            EndContext();
            BeginContext(565, 53, false);
#line 15 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
          Write(Model.TotalPage < Model.PageSize ? 1 : Model.PageSize);

#line default
#line hidden
            EndContext();
            BeginContext(619, 4, true);
            WriteLiteral(" of ");
            EndContext();
            BeginContext(624, 15, false);
#line 15 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                     Write(Model.TotalPage);

#line default
#line hidden
            EndContext();
            BeginContext(639, 50, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"clearfix\"></div>\r\n");
            EndContext();
#line 19 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
     foreach (var m in Model)
    {

        var tukhoa = ViewBag.tukhoa;

#line default
#line hidden
            BeginContext(767, 222, true);
            WriteLiteral("        <div class=\"col-sm-3 col-xs-6\" style=\"float:left;height:270px\">\r\n\r\n            <div class=\"product\">\r\n                <div class=\"product-image\">\r\n                    <div class=\"image\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 989, "\"", 1025, 4);
            WriteAttributeValue("", 996, "/Product/Detail/", 996, 16, true);
#line 28 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1012, m.Id, 1012, 5, false);

#line default
#line hidden
            WriteAttributeValue("", 1017, "/", 1017, 1, true);
#line 28 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1018, m.Name, 1018, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1026, 5, true);
            WriteLiteral("><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1031, "\"", 1074, 2);
            WriteAttributeValue("", 1037, "/Content/img/products/images/", 1037, 29, true);
#line 28 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1066, m.Image, 1066, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1075, 53, true);
            WriteLiteral("  alt=\"\" class=\"img-responsive\" style=\"height:150px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1128, "\"", 1138, 1);
#line 28 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1133, m.Id, 1133, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1139, 11, true);
            WriteLiteral("></a>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1224, 44, true);
            WriteLiteral("                    </div><!-- /.image -->\r\n");
            EndContext();
#line 33 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                     if (m.Special == true)
                    {

#line default
#line hidden
            BeginContext(1336, 69, true);
            WriteLiteral("                        <div class=\"tag hot\"><span>hot</span></div>\r\n");
            EndContext();
#line 36 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                    }

#line default
#line hidden
            BeginContext(1428, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                     if (m.Discount > 0)
                    {

#line default
#line hidden
            BeginContext(1495, 71, true);
            WriteLiteral("                        <div class=\"tag sale\"><span>sale</span></div>\r\n");
            EndContext();
#line 41 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"

                    }

#line default
#line hidden
            BeginContext(1591, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 43 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                     if (m.Latest == true)
                    {

#line default
#line hidden
            BeginContext(1658, 69, true);
            WriteLiteral("                        <div class=\"tag new\"><span>new</span></div>\r\n");
            EndContext();
#line 46 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"

                    }

#line default
#line hidden
            BeginContext(1752, 171, true);
            WriteLiteral("                </div><!-- /.product-image -->\r\n\r\n\r\n                <div class=\"product-info text-left\">\r\n                    <h3 class=\"name\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1923, "\"", 1951, 2);
            WriteAttributeValue("", 1930, "/Product/Detail/", 1930, 16, true);
#line 53 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
WriteAttributeValue("", 1946, m.Id, 1946, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1952, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 54 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                             if (tukhoa != null)
                            {
                                try
                                {
                                    

#line default
#line hidden
            BeginContext(2384, 17, false);
#line 60 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                               Write(Html.Raw(@m.Name));

#line default
#line hidden
            EndContext();
#line 60 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                      ;

                                }
                                catch
                                {
                                    

#line default
#line hidden
            BeginContext(2552, 6, false);
#line 65 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                               Write(m.Name);

#line default
#line hidden
            EndContext();
#line 65 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                           ;
                                }
                            }
                            else
                            {
                                

#line default
#line hidden
            BeginContext(2725, 6, false);
#line 70 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                           Write(m.Name);

#line default
#line hidden
            EndContext();
#line 70 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                       ;
                            }

#line default
#line hidden
            BeginContext(2765, 298, true);
            WriteLiteral(@"                        </a>

                    </h3>



                 
                    <div class=""description""></div>

                    <div class=""product-price"" style=""margin-top:5px"">
                        <span class=""price numeral-init"">
                            ");
            EndContext();
            BeginContext(3064, 37, false);
#line 83 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                       Write(Html.Raw(m.PriceP * (1 - m.Discount)));

#line default
#line hidden
            EndContext();
            BeginContext(3101, 35, true);
            WriteLiteral("\r\n                        </span>\r\n");
            EndContext();
#line 85 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                         if (m.Discount > 0)
                        {

#line default
#line hidden
            BeginContext(3209, 100, true);
            WriteLiteral("                            <span class=\"price-before-discount numeral-init\" style=\"font-size:11px\">");
            EndContext();
            BeginContext(3310, 8, false);
#line 87 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                               Write(m.PriceP);

#line default
#line hidden
            EndContext();
            BeginContext(3318, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 88 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                        }

#line default
#line hidden
            BeginContext(3354, 476, true);
            WriteLiteral(@"                        
                    </div><!-- /.product-price -->

                </div><!-- /.product-info -->
                <div class=""cart clearfix animate-effect"">
                    <div class=""action"">
                        <ul class=""list-unstyled"">
                            <li class=""add-cart-button btn-group"">
                                <button class=""btn btn-primary icon addProduct"" style=""padding:4px 8px"" type=""button"" data-id=""");
            EndContext();
            BeginContext(3831, 4, false);
#line 97 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                                                          Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3835, 226, true);
            WriteLiteral("\">\r\n                                    <i class=\"fa fa-shopping-cart\"></i>\r\n                                </button>\r\n                                <button class=\"btn btn-primary addProduct hidden\" type=\"button\"  data-id=\"");
            EndContext();
            BeginContext(4062, 4, false);
#line 100 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                                     Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4066, 196, true);
            WriteLiteral("\">Thêm vào giỏ</button>\r\n                                <button class=\"btn btn-primary addProduct\" type=\"button\" style=\"padding:4px 8px\"\r\n                                        data-urladdcart=\"");
            EndContext();
            BeginContext(4263, 51, false);
#line 102 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                    Write(Url.RouteUrl(new {controller="Cart",action="Add" }));

#line default
#line hidden
            EndContext();
            BeginContext(4314, 52, true);
            WriteLiteral("\"\r\n                                        data-id=\"");
            EndContext();
            BeginContext(4367, 4, false);
#line 103 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                            Write(m.Id);

#line default
#line hidden
            EndContext();
            BeginContext(4371, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(4385, 6, false);
#line 103 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                              Write(m.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4391, 12, true);
            WriteLiteral("\" data-url=\"");
            EndContext();
            BeginContext(4404, 7, false);
#line 103 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                 Write(m.Image);

#line default
#line hidden
            EndContext();
            BeginContext(4411, 23, true);
            WriteLiteral("\" data-urlpartialcart=\"");
            EndContext();
            BeginContext(4435, 65, false);
#line 103 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                                                Write(Url.RouteUrl(new { controller = "Cart", action = "PartialCart" }));

#line default
#line hidden
            EndContext();
            BeginContext(4500, 352, true);
            WriteLiteral(@""">
                                    Thêm vào giỏ
                                </button>
                            </li>

                          
                        </ul>
                    </div><!-- /.action -->
                </div><!-- /.cart -->
            </div><!-- /.product -->

        </div><!-- /.products -->
");
            EndContext();
#line 115 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"


    }

#line default
#line hidden
            BeginContext(4863, 98, true);
            WriteLiteral("    <div class=\"clearfix\"></div></br>\r\n\r\n    <div id=\"contentPagerListFooter\" class=\"pull-left\">\r\n");
            EndContext();
            BeginContext(5066, 33, true);
            WriteLiteral("        <div class=\"btn-group\">\r\n");
            EndContext();
#line 123 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
             for (int i = 1; i <= Model.TotalPage; i++)
            {
                

#line default
#line hidden
            BeginContext(5188, 118, false);
#line 125 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
           Write(Html.ActionLink(i.ToString(), "ListBySpecial", new { page = i, Id = ViewBag.Id }, new { @class = "btn btn-primary" } ));

#line default
#line hidden
            EndContext();
#line 125 "E:\New folder (2)\Web_Nang_Cao\WebMVC6\New folder\WebApplication8\WebApplication8\Views\Product\ProductList.cshtml"
                                                                                                                                       
            }

#line default
#line hidden
            BeginContext(5323, 89, true);
            WriteLiteral("        </div>\r\n       \r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n</section><!-- /.section -->\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5429, 714, true);
                WriteLiteral(@"


    <script>

        $(document).ready(function () {
            $(document).on(""click"", ""#contentPagerList a, #contentPagerListFooter a"", function () {
              
                $.ajax({
                    url: $(this).attr(""href""),
                 
                    type: 'GET',
                    cache: false,
                    success: function (response) {
                        result = $(response).find("".featured-product"");
                       
                    
                        $("".homebanner-holder"").html(result).replaceAll();
                    }
                });
                return false;
            });
        });


    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sakura.AspNetCore.IPagedList<WebApplication8.Models.WebShop.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591