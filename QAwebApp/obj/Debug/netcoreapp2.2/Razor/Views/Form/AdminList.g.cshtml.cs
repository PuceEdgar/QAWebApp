#pragma checksum "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74aeea271f7cd3267063cfaedb26a72342e9d3ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_AdminList), @"mvc.1.0.view", @"/Views/Form/AdminList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Form/AdminList.cshtml", typeof(AspNetCore.Views_Form_AdminList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74aeea271f7cd3267063cfaedb26a72342e9d3ca", @"/Views/Form/AdminList.cshtml")]
    public class Views_Form_AdminList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QAwebApp.Models.AdminModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(102, 13, true);
            WriteLiteral("\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(116, 40, false);
#line 6 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
Write(Html.ActionLink("Add Admin", "AddAdmin"));

#line default
#line hidden
            EndContext();
            BeginContext(156, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(249, 39, false);
#line 12 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
           Write(Html.DisplayNameFor(model => model.Sid));

#line default
#line hidden
            EndContext();
            BeginContext(288, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(344, 40, false);
#line 15 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(384, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(440, 41, false);
#line 18 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(481, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(616, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(677, 38, false);
#line 28 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Sid));

#line default
#line hidden
            EndContext();
            BeginContext(715, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(738, 36, false);
#line 29 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
               Write(Html.HiddenFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(774, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(842, 39, false);
#line 32 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(881, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(949, 40, false);
#line 35 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(989, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 38 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
                     using (Html.BeginForm("DeleteAdmin", "Form", FormMethod.Post, new { id = item.Id }))
                    {
                        

#line default
#line hidden
            BeginContext(1191, 23, false);
#line 40 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1241, 28, false);
#line 41 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
                   Write(Html.HiddenFor(m => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1271, 64, true);
            WriteLiteral("                        <input type=\"submit\" value=\"Delete\" />\r\n");
            EndContext();
#line 43 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
                    }

#line default
#line hidden
            BeginContext(1358, 23, true);
            WriteLiteral("                </td>\r\n");
            EndContext();
            BeginContext(1940, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 55 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
        }

#line default
#line hidden
            BeginContext(1970, 36, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n<h2>");
            EndContext();
            BeginContext(2007, 17, false);
#line 59 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(2024, 20, true);
            WriteLiteral("</h2>\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(2045, 40, false);
#line 62 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\AdminList.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(2085, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QAwebApp.Models.AdminModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591