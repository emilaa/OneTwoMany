#pragma checksum "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a786e2c3295141c88fc1bb5b37ddd2ac86dca924"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accordion_Index), @"mvc.1.0.view", @"/Views/Accordion/Index.cshtml")]
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
#line 1 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\_ViewImports.cshtml"
using OneTwoMany_Fiorello;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\_ViewImports.cshtml"
using OneTwoMany_Fiorello.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\_ViewImports.cshtml"
using OneTwoMany_Fiorello.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a786e2c3295141c88fc1bb5b37ddd2ac86dca924", @"/Views/Accordion/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d4dd0d835ae55bf52f9974f7f2c8ad1cf251d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Accordion_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AccordionVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
  
    ViewData["Title"] = "Accordion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"accordion-title\">\r\n    <div class=\"container py-4\">\r\n        <div class=\"row py-5\">\r\n            <div class=\"col-12\">\r\n                <h1>");
#nullable restore
#line 11 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
               Write(Model.AccordionTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<section id=\"accordion\">\r\n    <div class=\"container\">\r\n        <div class=\"row accordion\">\r\n            <div class=\"col-md-6 my-5\">\r\n");
#nullable restore
#line 20 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                  
                    bool isFirstTime = true;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                     foreach (var accordionDetail in Model.AccordionDetails)
                    {
                        if (isFirstTime)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question active border p-3 mt-3\">\r\n                                <i class=\"fas fa-minus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 29 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer active\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 33 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 36 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question border p-3 mt-3\">\r\n                                <i class=\"fas fa-plus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 42 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 46 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 49 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }

                        isFirstTime = false;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-6 my-5\">\r\n");
#nullable restore
#line 57 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                  
                    bool isFirstTime2 = true;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                     foreach (var accordionDetail in Model.AccordionDetails)
                    {
                        if (isFirstTime2)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question active border p-3 mt-3\">\r\n                                <i class=\"fas fa-minus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 66 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer active\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 70 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 73 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question border p-3 mt-3\">\r\n                                <i class=\"fas fa-plus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 79 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 83 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 86 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }

                        isFirstTime2 = false;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row accordion-color\">\r\n            <div class=\"col-md-6 my-5\">\r\n");
#nullable restore
#line 96 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                  
                    bool isFirstTime3 = true;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                     foreach (var accordionDetail in Model.AccordionDetails)
                    {
                        if (isFirstTime3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question active border p-3 mt-3\">\r\n                                <i class=\"fas fa-minus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 105 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer active\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 109 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 112 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question border p-3 mt-3\">\r\n                                <i class=\"fas fa-plus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 118 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 122 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 125 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }

                        isFirstTime3 = false;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <div class=\"col-md-6 my-5\">\r\n");
#nullable restore
#line 133 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                  
                    bool isFirstTime4 = true;

                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                     foreach (var accordionDetail in Model.AccordionDetails)
                    {
                        if (isFirstTime4)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question active border p-3 mt-3\">\r\n                                <i class=\"fas fa-minus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 142 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer active\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 146 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 149 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }
                        else
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"question border p-3 mt-3\">\r\n                                <i class=\"fas fa-plus fa-sm mr-2\"></i>\r\n                                <span>");
#nullable restore
#line 155 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                                 Write(accordionDetail.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            </div>\r\n                            <div class=\"answer\">\r\n                                <p class=\"py-3\">\r\n                                    ");
#nullable restore
#line 159 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                               Write(accordionDetail.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 162 "C:\Users\Emil Abdullayev\Desktop\BackEnd\OneTwoMany\OneTwoMany-Fiorello\OneTwoMany-Fiorello\Views\Accordion\Index.cshtml"
                        }

                        isFirstTime4 = false;

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AccordionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
