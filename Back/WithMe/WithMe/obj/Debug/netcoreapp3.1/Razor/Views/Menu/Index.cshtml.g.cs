#pragma checksum "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e03eb6fba00506e0e1c26fd7aabf688419acb32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Index), @"mvc.1.0.view", @"/Views/Menu/Index.cshtml")]
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
#line 2 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\_ViewImports.cshtml"
using WithMe.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\_ViewImports.cshtml"
using WithMe.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e03eb6fba00506e0e1c26fd7aabf688419acb32", @"/Views/Menu/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"811aa82eecfec33c8e45c145f09fc29b332d960f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Menu_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MenuVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SecondMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section class=\"fortitle\">\r\n        <div class=\"title\" data-aos=\"fade-down\" data-aos-duration=\"1000\">\r\n            <h1>");
#nullable restore
#line 9 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
           Write(Model.titlesectionformenupage.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <div class=\"container\">\r\n                <div class=\"menu\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e03eb6fba00506e0e1c26fd7aabf688419acb324732", async() => {
                WriteLiteral("<span>First Menu</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"menu\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e03eb6fba00506e0e1c26fd7aabf688419acb326196", async() => {
                WriteLiteral("<span>Third Menu</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </section>
    <section class=""formenu"">
        <div class=""firstmenu"">
            <div class=""container"">
                <div class=""title"" data-aos=""fade-in"" data-aos-duration=""1000"">
                    <h1 data-aos=""fade-down"" data-aos-duration=""1000"">
");
#nullable restore
#line 25 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                         foreach (var item in Model.maincoursessectionformenupage.Take(1))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </h1>
                </div>
            </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""leftcol"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""400"">
");
#nullable restore
#line 36 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.maincoursessectionformenupage.Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 41 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 43 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 45 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 47 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <div class=\"rightcol\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"500\"  style=\"padding-left: 2rem;\">\r\n");
#nullable restore
#line 52 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.maincoursessectionformenupage.Skip(8).Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                           <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 57 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 59 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 61 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 63 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""firstmenu"">
            <div class=""container"">
                <div class=""title"" data-aos=""fade-in"" data-aos-duration=""1000"" style=""background-image:   
                linear-gradient(
                    rgba(0, 0, 0, 0.4), 
                    rgba(0, 0, 0, 0.4)
                  ),  url(./assets/images/drinkbackground.jpg);"">
                    <h1 data-aos=""fade-down"" data-aos-duration=""1000"">
");
#nullable restore
#line 77 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                         foreach (var item in Model.drinkssectionformenupages.Take(1))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </h1>
                </div>
            </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""leftcol"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""400"">
");
#nullable restore
#line 88 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.drinkssectionformenupages.Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 93 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 95 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 97 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 99 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <div class=\"rightcol\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"500\"  style=\"padding-left: 2rem;\">\r\n");
#nullable restore
#line 104 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.drinkssectionformenupages.Skip(8).Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 109 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 111 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 113 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 115 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""firstmenu"">
            <div class=""container"">
                <div class=""title"" data-aos=""fade-in"" data-aos-duration=""1000"" style=""background-image:
                linear-gradient(
                rgba(0, 0, 0, 0.4), 
                rgba(0, 0, 0, 0.4)
              ),  url(./assets/images/dessertback.jpg);"">
                    <h1 data-aos=""fade-down"" data-aos-duration=""1000"">
");
#nullable restore
#line 129 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                         foreach (var item in Model.dessertsectionformenupages.Take(1))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 131 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                   
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </h1>
                </div>
            </div>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-6"">
                        <div class=""leftcol"" data-aos=""fade-up"" data-aos-duration=""1000"" data-aos-delay=""400"">
");
#nullable restore
#line 140 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.dessertsectionformenupages.Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 145 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 147 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 149 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 151 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                    <div class=\"col-6\">\r\n                        <div class=\"rightcol\" data-aos=\"fade-up\" data-aos-duration=\"1000\" data-aos-delay=\"500\"  style=\"padding-left: 2rem;\">\r\n");
#nullable restore
#line 156 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                             foreach (var item in Model.dessertsectionformenupages.Skip(8).Take(8))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"menuitem\">\r\n                                <div class=\"menu-header\">\r\n                                    <div class=\"menu-title\">\r\n                                        <h5>");
#nullable restore
#line 161 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                    </div>\r\n                                    <span>$");
#nullable restore
#line 163 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                                      Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </div>\r\n                                <p>");
#nullable restore
#line 165 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                              Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 167 "C:\Users\USER\Desktop\Restaurant\Back\WithMe\WithMe\Views\Menu\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MenuVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
