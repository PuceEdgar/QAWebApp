#pragma checksum "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fac1572c535c915098707101aafad824b73d865"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Form_Edit), @"mvc.1.0.view", @"/Views/Form/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Form/Edit.cshtml", typeof(AspNetCore.Views_Form_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fac1572c535c915098707101aafad824b73d865", @"/Views/Form/Edit.cshtml")]
    public class Views_Form_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QAwebApp.Models.FormModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(74, 19, true);
            WriteLiteral("<h2>Edit</h2>\r\n<h3>");
            EndContext();
            BeginContext(94, 17, false);
#line 8 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(111, 7, true);
            WriteLiteral("</h3>\r\n");
            EndContext();
#line 9 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
 using (Html.BeginForm("Edit", "Form", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(184, 23, false);
#line 11 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(211, 231, true);
            WriteLiteral("    <div class=\"form-horizontal container-fluid\">\r\n        <h4>Form</h4>\r\n        <hr />\r\n        <div class=\"container-fluid row\">\r\n            <div class=\"col-md-6\">\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(443, 97, false);
#line 19 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.Division, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(540, 72, true);
            WriteLiteral("\r\n\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(613, 97, false);
#line 22 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Division, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(710, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(739, 39, false);
#line 24 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Division));

#line default
#line hidden
            EndContext();
            BeginContext(778, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(895, 93, false);
#line 28 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.Bul1, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(988, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(1059, 93, false);
#line 30 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Bul1, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1152, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(1181, 35, false);
#line 32 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Bul1));

#line default
#line hidden
            EndContext();
            BeginContext(1216, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1333, 93, false);
#line 36 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.Bul2, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1426, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(1497, 93, false);
#line 38 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Bul2, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1590, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(1619, 35, false);
#line 40 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Bul2));

#line default
#line hidden
            EndContext();
            BeginContext(1654, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1771, 93, false);
#line 44 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.Bul3, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(1864, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(1935, 93, false);
#line 46 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Bul3, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(2057, 35, false);
#line 48 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Bul3));

#line default
#line hidden
            EndContext();
            BeginContext(2092, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2209, 96, false);
#line 52 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.Country, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2305, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(2376, 96, false);
#line 54 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.Country, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2472, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(2501, 38, false);
#line 56 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.Country));

#line default
#line hidden
            EndContext();
            BeginContext(2539, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(2656, 105, false);
#line 60 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.AssessmentPeriod, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(2761, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(2832, 105, false);
#line 62 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.AssessmentPeriod, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2937, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(2966, 47, false);
#line 64 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.AssessmentPeriod));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 118, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3132, 101, false);
#line 69 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.UnitAssessor, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3233, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(3304, 101, false);
#line 71 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.UnitAssessor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3405, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(3434, 43, false);
#line 73 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.UnitAssessor));

#line default
#line hidden
            EndContext();
            BeginContext(3477, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(3594, 105, false);
#line 77 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
               Write(Html.LabelFor(model => model.DateOfAssessment, htmlAttributes: new { @class = "control-label col-md-3" }));

#line default
#line hidden
            EndContext();
            BeginContext(3699, 70, true);
            WriteLiteral("\r\n                    <div class=\"col-md-6\">\r\n                        ");
            EndContext();
            BeginContext(3770, 105, false);
#line 79 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.EditorFor(model => model.DateOfAssessment, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3875, 28, true);
            WriteLiteral("\r\n\r\n                        ");
            EndContext();
            BeginContext(3904, 47, false);
#line 81 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(model => model.DateOfAssessment));

#line default
#line hidden
            EndContext();
            BeginContext(3951, 281, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col-md-6"">
                <h3>Unit Responsible</h3>
                <div class=""form-group row"">
                    <div class=""col-md-2 control-label"">
                        ");
            EndContext();
            BeginContext(4233, 50, false);
#line 89 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.LabelFor(model => model.UnitResponsible.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4283, 114, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-3 control-label\">\r\n                        ");
            EndContext();
            BeginContext(4398, 44, false);
#line 93 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.DisplayFor(m => m.UnitResponsible.Name));

#line default
#line hidden
            EndContext();
            BeginContext(4442, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(4469, 40, false);
#line 94 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.HiddenFor(m => m.UnitResponsibleId));

#line default
#line hidden
            EndContext();
            BeginContext(4509, 184, true);
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group row\">\r\n                    <div class=\"col-md-2 control-label\">\r\n                        ");
            EndContext();
            BeginContext(4694, 51, false);
#line 100 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.LabelFor(model => model.UnitResponsible.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4745, 114, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"col-md-3 control-label\">\r\n                        ");
            EndContext();
            BeginContext(4860, 53, false);
#line 104 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
                   Write(Html.DisplayFor(model => model.UnitResponsible.Email));

#line default
#line hidden
            EndContext();
            BeginContext(4913, 1062, true);
            WriteLiteral(@"



                    </div>
                </div>


            </div>
        </div>


        <br />
        <hr />
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <h4>Grading Criteria</h4>
            </div>

            <div class=""col-md-1"">
                <h4>Max Score</h4>
            </div>

            <div class=""col-md-4"">
                <h4>
                    Group Risk comment to scoring
                    (Mandatory to fill in)
                </h4>
            </div>

            <div class=""col-md-1"">
                <h4>Score</h4>
            </div>

            <div class=""col-md-4"">
                <h4>Unit comment to score</h4>
            </div>

        </div>
        <div class=""row"">

            <div class=""col-md-2"">
                <p>1. Business Continuity Management</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <d");
            WriteLiteral("iv class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(5976, 113, false);
#line 155 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.BCMGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6089, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(6110, 43, false);
#line 157 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.BCMGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(6153, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(6230, 109, false);
#line 161 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.BCMScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6339, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(6360, 39, false);
#line 163 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.BCMScore));

#line default
#line hidden
            EndContext();
            BeginContext(6399, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(6476, 115, false);
#line 167 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.BCMUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6591, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(6612, 45, false);
#line 169 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.BCMUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(6657, 332, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>2 Incident Reporting and Handling</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(6990, 113, false);
#line 184 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.IRHGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7103, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(7124, 43, false);
#line 186 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.IRHGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(7167, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(7244, 109, false);
#line 190 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.IRHScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7353, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(7374, 39, false);
#line 192 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.IRHScore));

#line default
#line hidden
            EndContext();
            BeginContext(7413, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(7490, 115, false);
#line 196 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.IRHUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7605, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(7626, 45, false);
#line 198 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.IRHUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(7671, 330, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>3. New Product Approval Process</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(8002, 114, false);
#line 213 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.NPAPGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(8116, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(8137, 44, false);
#line 215 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.NPAPGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(8181, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(8258, 110, false);
#line 219 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.NPAPScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(8368, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(8389, 40, false);
#line 221 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.NPAPScore));

#line default
#line hidden
            EndContext();
            BeginContext(8429, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(8506, 116, false);
#line 225 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.NPAPUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(8622, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(8643, 46, false);
#line 227 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.NPAPUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(8689, 311, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>4. ORSA/RTSA</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(9001, 118, false);
#line 242 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ORSARTSAGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9119, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(9140, 48, false);
#line 244 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ORSARTSAGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(9188, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(9265, 114, false);
#line 248 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ORSARTSAScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9379, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(9400, 44, false);
#line 250 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ORSARTSAScore));

#line default
#line hidden
            EndContext();
            BeginContext(9444, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(9521, 120, false);
#line 254 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ORSARTSAUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9641, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(9662, 50, false);
#line 256 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ORSARTSAUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(9712, 338, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>5. To what extent are KRI's implemented</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(10051, 113, false);
#line 271 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.KRIGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10164, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(10185, 43, false);
#line 273 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.KRIGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(10228, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(10305, 109, false);
#line 277 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.KRIScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10414, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(10435, 39, false);
#line 279 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.KRIScore));

#line default
#line hidden
            EndContext();
            BeginContext(10474, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(10551, 115, false);
#line 283 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.KRIUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10666, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(10687, 45, false);
#line 285 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.KRIUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(10732, 362, true);
            WriteLiteral(@"
            </div>

        </div>

        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>6. To what extent are Internal Control checklists implemented</p>
            </div>

            <div class=""col-md-1"">
                <p>4</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(11095, 113, false);
#line 301 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ICCGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(11208, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(11229, 43, false);
#line 303 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ICCGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(11272, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(11349, 109, false);
#line 307 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ICCScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(11458, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(11479, 39, false);
#line 309 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ICCScore));

#line default
#line hidden
            EndContext();
            BeginContext(11518, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(11595, 115, false);
#line 313 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.ICCUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(11710, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(11731, 45, false);
#line 315 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.ICCUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(11776, 321, true);
            WriteLiteral(@"
            </div>

        </div>
        <div class=""form-group row"">

            <div class=""col-md-2"">
                <p>Total score / comment</p>
            </div>

            <div class=""col-md-1"">
                <p>24</p>
            </div>

            <div class=""col-md-4"">
                ");
            EndContext();
            BeginContext(12098, 117, false);
#line 330 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.SummaryGrComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(12215, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(12236, 47, false);
#line 332 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.SummaryGrComment));

#line default
#line hidden
            EndContext();
            BeginContext(12283, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-1\">\r\n                ");
            EndContext();
            BeginContext(12360, 111, false);
#line 336 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.TotalScore, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(12471, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(12492, 41, false);
#line 338 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.TotalScore));

#line default
#line hidden
            EndContext();
            BeginContext(12533, 76, true);
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col-md-4\">\r\n                ");
            EndContext();
            BeginContext(12610, 119, false);
#line 342 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.EditorFor(model => model.SummaryUnitComment, new { htmlAttributes = new { @class = "form-control", @id = "lg" } }));

#line default
#line hidden
            EndContext();
            BeginContext(12729, 20, true);
            WriteLiteral("\r\n\r\n                ");
            EndContext();
            BeginContext(12750, 49, false);
#line 344 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(model => model.SummaryUnitComment));

#line default
#line hidden
            EndContext();
            BeginContext(12799, 155, true);
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-6 col-md-10\">\r\n                ");
            EndContext();
            BeginContext(12955, 33, false);
#line 356 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
           Write(Html.HiddenFor(m => m.ManagerSid));

#line default
#line hidden
            EndContext();
            BeginContext(12988, 158, true);
            WriteLiteral("\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" onhover=\"background-color: yellow;\" />\r\n                <a class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 13146, "\"", 13181, 1);
#line 358 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
WriteAttributeValue("", 13153, Url.Action("Index", "Form"), 13153, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(13182, 61, true);
            WriteLiteral(">Cancel</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 362 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"



}

#line default
#line hidden
            BeginContext(13252, 19, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n\r\n    ");
            EndContext();
            BeginContext(13272, 40, false);
#line 371 "C:\Users\s5143b\source\repos\QAwebApp\QAwebApp\Views\Form\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(13312, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QAwebApp.Models.FormModel> Html { get; private set; }
    }
}
#pragma warning restore 1591