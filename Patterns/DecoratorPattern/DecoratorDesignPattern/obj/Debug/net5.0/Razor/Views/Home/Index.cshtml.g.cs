#pragma checksum "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91c4161b484e0dc497a78dc2de9d117b32e426a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\_ViewImports.cshtml"
using DecoratorDesignPattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\_ViewImports.cshtml"
using DecoratorDesignPattern.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c4161b484e0dc497a78dc2de9d117b32e426a8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e1c46b379c9c39ab12dcbffe35ead7a5952f1eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DecoratorDesignPattern.WeatherInterface.CurrentWeather>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApiKey", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div>
    <div class=""row"">
        <div class=""col-sm-8"">
            <h1 class=""display-4"">Welcome</h1>
            <p>Learn about the Decorator design pattern</p>
            <p>Be sure to have obtained an API key from OpenWeatherMap.org and placed it in your appSettings.json file.  For instructions, go to
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c4161b484e0dc497a78dc2de9d117b32e426a85276", async() => {
                WriteLiteral("Get an API Key");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </p>\n        </div>\n        <div class=\"col-sm-4\">\n            <div class=\"card\" style=\"width: 22rem;\">\n\n");
#nullable restore
#line 20 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                 if (@Model.Success)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-header text-white bg-primary\">\n                        Weather for ");
#nullable restore
#line 23 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                               Write(Model.Location.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"card-body\">\n                        <h6 class=\"card-subtitle mb-2 text-muted\">Observed at ");
#nullable restore
#line 26 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                                         Write(Model.ObservationTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Conditions</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 30 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.Conditions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Visibility</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 35 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.Visibility.ToString("#0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" miles</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Cloud Cover</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 40 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.CloudCover);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Temperature</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 45 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.Temperature.ToString("#0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &deg; F</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Humidity</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 50 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.Humidity.ToString("#0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Barometer</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 55 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.Pressure.ToString("#0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" in/Hg</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Wind</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 60 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.WindDirection.Abbreviation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 60 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                                                                            Write(Model.CurrentConditions.WindSpeed.ToString("#0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" mph</div>\n                        </div>\n\n                        <div class=\"row\">\n                            <div class=\"col-sm-6 font-weight-bold text-left\">Rainfall (1 hour)</div>\n                            <div class=\"col-sm-6 text-right\">");
#nullable restore
#line 65 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                                        Write(Model.CurrentConditions.RainfallOneHour.ToString("#0.00"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" in</div>\n                        </div>\n\n                        <p class=\"text-muted text-center\" style=\"margin: 6px\">\n                            Fetch time: ");
#nullable restore
#line 69 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                                   Write(Model.FetchTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </p>\n                    </div>\n                    <div class=\"card-body text-left\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c4161b484e0dc497a78dc2de9d117b32e426a813795", async() => {
                WriteLiteral(@"
                            <span class=""font-weight-bold"" style=""margin-bottom: 5px"">Get Weather</span>
                            <div class=""row"">
                                <div class=""col-sm-9"">
                                    <input id=""weatherCity"" name=""location"" class=""form-control"" type=""text"" placeholder=""City name"" />
                                </div>
                                <div class=""col-sm-3"">
                                    <button type=""submit"" id=""getWeather"" class=""btn btn-primary"">Get</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                    </div>\n");
#nullable restore
#line 86 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-header text-white bg-danger\">\n                        ");
#nullable restore
#line 90 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                   Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>\n                    <div class=\"card-body text-left\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91c4161b484e0dc497a78dc2de9d117b32e426a816683", async() => {
                WriteLiteral(@"
                            <span class=""font-weight-bold"" style=""margin-bottom: 5px"">Get Weather</span>
                            <div class=""row"">
                                <div class=""col-sm-9"">
                                    <input id=""weatherCity"" name=""location"" class=""form-control"" type=""text"" placeholder=""City name"" />
                                </div>
                                <div class=""col-sm-3"">
                                    <button type=""submit"" id=""getWeather"" class=""btn btn-primary"">Get</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                    </div>\n");
#nullable restore
#line 106 "C:\Users\olufe\source\repos\PluralSight\Patterns\DecoratorPattern\DecoratorDesignPattern\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DecoratorDesignPattern.WeatherInterface.CurrentWeather> Html { get; private set; }
    }
}
#pragma warning restore 1591
