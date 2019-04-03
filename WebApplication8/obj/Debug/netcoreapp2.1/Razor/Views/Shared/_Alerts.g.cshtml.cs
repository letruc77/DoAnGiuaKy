#pragma checksum "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fc172499d90a7dba14cc9efba33fb3fd1f2593"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Alerts), @"mvc.1.0.view", @"/Views/Shared/_Alerts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Alerts.cshtml", typeof(AspNetCore.Views_Shared__Alerts))]
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
#line 1 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
using WebApplication8.Models.UtilEntities;

#line default
#line hidden
#line 2 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6fc172499d90a7dba14cc9efba33fb3fd1f2593", @"/Views/Shared/_Alerts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9902d642f80e647e7edd6b1baa8f080cbac5746b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Alerts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
  
        List<Alert> alerts = new List<Alert>(); ;
        if (TempData.ContainsKey(Alert.TempDataKey))
        {
            var x = (Newtonsoft.Json.Linq.JArray)JsonConvert.DeserializeObject(TempData[Alert.TempDataKey] + "");

            if (x.Any())
            {

                foreach (var alert in x)
                {
                    Alert alert_ = new Alert()
                    {
                     AlertStyle = alert.ElementAt(0).ToString().Replace("\"AlertStyle\":", "").Replace("\"", "").Replace(" ", ""),
                     Message = alert.ElementAt(1).ToString().Replace("\"Message\":", "").Replace("\"", ""),
                     Dismissable = (bool)alert.ElementAt(2)
                     };
                alerts.Add(alert_);
              //  string as_ = alert.ElementAt(0).ToString().Replace("\"AlertStyle\":", "").Replace("\"","");
                //as_.Replace("\"AlertStyle\":", "");

            }

        }

    }
    if (alerts.Any())
    {
        foreach (var alert in alerts)
        {
            var dismissableClass = alert.Dismissable ? "alert-dismissable" : null;

#line default
#line hidden
            BeginContext(1214, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1230, "\"", 1285, 4);
            WriteAttributeValue("", 1238, "alert", 1238, 5, true);
            WriteAttributeValue(" ", 1243, "alert-", 1244, 7, true);
#line 34 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
WriteAttributeValue("", 1250, alert.AlertStyle, 1250, 17, false);

#line default
#line hidden
#line 34 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
WriteAttributeValue(" ", 1267, dismissableClass, 1268, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1286, 38, true);
            WriteLiteral(" aria-hidden=\"true\" id=\"id-alert\">\r\n\r\n");
            EndContext();
#line 36 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
                 if (alert.Dismissable)
                {

#line default
#line hidden
            BeginContext(1384, 114, true);
            WriteLiteral("                    <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-hidden=\"true\">&times;</button>\r\n");
            EndContext();
#line 39 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
                }

#line default
#line hidden
            BeginContext(1517, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1534, 23, false);
#line 40 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
           Write(Html.Raw(alert.Message));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
#line 42 "C:\Users\letru\Desktop\DoAnGiuaKy\WebApplication8\Views\Shared\_Alerts.cshtml"
        }

    }




#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
