#pragma checksum "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a89dccee65713b8b57844830a688394e5473ec1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_IndexManager), @"mvc.1.0.view", @"/Views/Form/IndexManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Form/IndexManager.cshtml", typeof(AspNetCore.Views_Form_IndexManager))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a89dccee65713b8b57844830a688394e5473ec1", @"/Views/Form/IndexManager.cshtml")]
    public class Views_Form_IndexManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QAwebApp.ViewModels.FormViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 10, true);
            WriteLiteral("\r\n\r\n\r\n<h2>");
            EndContext();
            BeginContext(53, 11, false);
#line 5 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(64, 17, true);
            WriteLiteral("</h2>\r\n<h3>Hello ");
            EndContext();
            BeginContext(82, 13, false);
#line 6 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
     Write(Model.AppUser);

#line default
#line hidden
            EndContext();
            BeginContext(95, 278, true);
            WriteLiteral(@"</h3>






<table class=""table"">
    <tr>
        <td>
            Division
        </td>
        <td>
            Country
        </td>
        <td>
            Unit Responsible
        </td>
        <td>
            Email Status
        </td>
    </tr>
");
            EndContext();
#line 28 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
     foreach (var item in Model.Forms)
    {


#line default
#line hidden
            BeginContext(422, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(471, 35, false);
#line 33 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.DisplayFor(m => item.Division));

#line default
#line hidden
            EndContext();
            BeginContext(506, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(562, 34, false);
#line 36 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.DisplayFor(m => item.Country));

#line default
#line hidden
            EndContext();
            BeginContext(596, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(652, 47, false);
#line 39 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.DisplayFor(m => item.UnitResponsible.Name));

#line default
#line hidden
            EndContext();
            BeginContext(699, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(755, 36, false);
#line 42 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.DisplayFor(m => item.EmailSent));

#line default
#line hidden
            EndContext();
            BeginContext(791, 57, true);
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(849, 60, false);
#line 46 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.ActionLink("Edit", "EditManager", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(909, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(930, 59, false);
#line 47 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(989, 56, true);
            WriteLiteral(" |\r\n              \r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\IndexManager.cshtml"
    }

#line default
#line hidden
            BeginContext(1052, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QAwebApp.ViewModels.FormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591