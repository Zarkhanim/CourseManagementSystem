#pragma checksum "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d64ac1e1177561f8f527f546fe5dc24bf55f775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_ListOfStudents), @"mvc.1.0.view", @"/Views/Students/ListOfStudents.cshtml")]
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
#line 1 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\_ViewImports.cshtml"
using Course;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\_ViewImports.cshtml"
using Course.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d64ac1e1177561f8f527f546fe5dc24bf55f775", @"/Views/Students/ListOfStudents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376b029bb33b6341e99c19af0cfb4e3c2e2706cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_ListOfStudents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Students>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d64ac1e1177561f8f527f546fe5dc24bf55f7754207", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6d64ac1e1177561f8f527f546fe5dc24bf55f7754587", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d64ac1e1177561f8f527f546fe5dc24bf55f7756469", async() => {
                WriteLiteral(@"
    <h5><a href=""/Students/AddStudent"">Add Student</a></h5><br /><br />
    <h3>Student list</h3>
    <table class=""table"">
        <thead>
            <tr>
                <th>First Name</th>
                <th>Last Name</th>
                <th>Fathet Name</th>
                <th>Birtdate</th>
                <th>Enrollment Date</th>
                <th>Mail</th>
                <th>Mobile</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 27 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                 if (@item.Status == 1)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 32 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FatherName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Birthdate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 36 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.EnrollmentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 37 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 38 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Active</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1343, "\"", 1379, 2);
                WriteAttributeValue("", 1350, "/Students/GetStudent/", 1350, 21, true);
#nullable restore
#line 40 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
WriteAttributeValue("", 1371, item.ID, 1371, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a><a");
                BeginWriteAttribute("href", " href=\"", 1391, "\"", 1430, 2);
                WriteAttributeValue("", 1398, "/Students/DeleteStudent/", 1398, 24, true);
#nullable restore
#line 40 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
WriteAttributeValue("", 1422, item.ID, 1422, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a></td>\r\n");
#nullable restore
#line 41 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                }
                else if (@item.Status == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 44 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 46 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FatherName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Birthdate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.EnrollmentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Waiting for confirmation</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 1972, "\"", 2012, 2);
                WriteAttributeValue("", 1979, "/Students/ConfirmStudent/", 1979, 25, true);
#nullable restore
#line 52 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
WriteAttributeValue("", 2004, item.ID, 2004, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Confirm</a></td>\r\n");
#nullable restore
#line 53 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>");
#nullable restore
#line 56 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.LastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.FatherName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Birthdate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.EnrollmentDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 61 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mail);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
                   Write(item.Mobile);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>Deleted Student</td>\r\n                    <td><a");
                BeginWriteAttribute("href", " href=\"", 2523, "\"", 2562, 2);
                WriteAttributeValue("", 2530, "/Students/EnableStudent/", 2530, 24, true);
#nullable restore
#line 64 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
WriteAttributeValue("", 2554, item.ID, 2554, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Enable</a></td>\r\n");
#nullable restore
#line 65 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tr>\r\n");
#nullable restore
#line 69 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\ListOfStudents.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Students>> Html { get; private set; }
    }
}
#pragma warning restore 1591
