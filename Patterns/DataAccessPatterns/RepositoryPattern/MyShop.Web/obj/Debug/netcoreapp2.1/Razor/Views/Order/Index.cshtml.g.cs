#pragma checksum "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "119ce2c0250acf28cc776a8e20e0525c19089a11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
#line 1 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web;

#line default
#line hidden
#line 2 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\_ViewImports.cshtml"
using MyShop.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"119ce2c0250acf28cc776a8e20e0525c19089a11", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7ded7ce34b44ae537591d6ad72e0fcf8f0236eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyShop.Domain.Models.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "All orders";

#line default
#line hidden
            BeginContext(96, 21, true);
            WriteLiteral("\r\n<h1>Orders</h1>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
 foreach (var order in Model)
{

#line default
#line hidden
            BeginContext(151, 264, true);
            WriteLiteral(@"    <div class=""row mb-lg-5"">
        <div class=""col-lg-8"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Order #</span>
                <span class=""badge badge-secondary badge-pill"">");
            EndContext();
            BeginContext(416, 13, false);
#line 15 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                                                          Write(order.OrderId);

#line default
#line hidden
            EndContext();
            BeginContext(429, 65, true);
            WriteLiteral("</span>\r\n            </h4>\r\n            <ul class=\"list-group\">\r\n");
            EndContext();
#line 18 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                 foreach (var item in order.LineItems)
                {

#line default
#line hidden
            BeginContext(569, 170, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                        <div>\r\n                            <h6 class=\"my-0\">");
            EndContext();
            BeginContext(740, 17, false);
#line 22 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                                        Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(757, 71, true);
            WriteLiteral("</h6>\r\n                            <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(829, 13, false);
#line 23 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                                                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(842, 92, true);
            WriteLiteral("</small>\r\n                        </div>\r\n                        <span class=\"text-muted\">$");
            EndContext();
            BeginContext(936, 34, false);
#line 25 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                                              Write(item.Product.Price * item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(971, 36, true);
            WriteLiteral("</span>\r\n                    </li>\r\n");
            EndContext();
#line 27 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1026, 154, true);
            WriteLiteral("\r\n                <li class=\"list-group-item d-flex justify-content-between\">\r\n                    <span>Total (USD)</span>\r\n                    <strong>$");
            EndContext();
            BeginContext(1181, 16, false);
#line 31 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
                        Write(order.OrderTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1197, 81, true);
            WriteLiteral("</strong>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Users\olufe\source\repos\PluralSight\Patterns\DataAccessPatterns\RepositoryPattern\MyShop.Web\Views\Order\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyShop.Domain.Models.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
