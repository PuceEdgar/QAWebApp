#pragma checksum "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0f67d02e61da38f6c74304c2a0488ff286083d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__GetUser), @"mvc.1.0.view", @"/Views/Shared/_GetUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_GetUser.cshtml", typeof(AspNetCore.Views_Shared__GetUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0f67d02e61da38f6c74304c2a0488ff286083d1", @"/Views/Shared/_GetUser.cshtml")]
    public class Views_Shared__GetUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QAwebApp.Models.FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
 using (Html.BeginForm("Assign", "Form", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(106, 23, false);
#line 6 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(131, 131, true);
            WriteLiteral("    <div>\r\n\r\n        <h4>User Details:</h4>\r\n        <hr />\r\n        <dl class=\"dl-horizontal\">\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(263, 45, false);
#line 13 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayNameFor(model => model.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(308, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(364, 41, false);
#line 16 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayFor(model => model.User.Name));

#line default
#line hidden
            EndContext();
            BeginContext(405, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(461, 44, false);
#line 19 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayNameFor(model => model.User.Sid));

#line default
#line hidden
            EndContext();
            BeginContext(505, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(561, 40, false);
#line 22 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayFor(model => model.User.Sid));

#line default
#line hidden
            EndContext();
            BeginContext(601, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(657, 46, false);
#line 25 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(703, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(759, 42, false);
#line 28 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
           Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
            EndContext();
            BeginContext(801, 33, true);
            WriteLiteral("\r\n            </dd>\r\n            ");
            EndContext();
            BeginContext(835, 25, false);
#line 30 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
            EndContext();
            BeginContext(860, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(875, 33, false);
#line 31 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
       Write(Html.HiddenFor(m => m.ManagerSid));

#line default
#line hidden
            EndContext();
            BeginContext(908, 148, true);
            WriteLiteral("\r\n        </dl>\r\n\r\n\r\n    </div>\r\n    <div>\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        <a class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1056, "\"", 1091, 1);
#line 38 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
WriteAttributeValue("", 1063, Url.Action("Index", "Form"), 1063, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1092, 27, true);
            WriteLiteral(">Cancel</a>\r\n\r\n    </div>\r\n");
            EndContext();
#line 41 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Shared\_GetUser.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QAwebApp.Models.FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591