#pragma checksum "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad961280685300dead28d621fed54257a56ad04a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_AddStudent), @"mvc.1.0.view", @"/Views/Students/AddStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad961280685300dead28d621fed54257a56ad04a", @"/Views/Students/AddStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376b029bb33b6341e99c19af0cfb4e3c2e2706cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Students>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad961280685300dead28d621fed54257a56ad04a4616", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad961280685300dead28d621fed54257a56ad04a4996", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ad961280685300dead28d621fed54257a56ad04a6174", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 10 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad961280685300dead28d621fed54257a56ad04a8917", async() => {
                WriteLiteral("\r\n    <h3>Add Student</h3><br /><br />\r\n    <div>\r\n");
#nullable restore
#line 15 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
         using (Html.BeginForm("AddStudent", "Students", FormMethod.Post))
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 19 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.FirstName, new { @placeholder = "First name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 20 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.FirstName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 22 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 23 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.LastName, new { @placeholder = "Last name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 24 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 26 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.FatherName));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 27 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.FatherName, new { @placeholder = "Father name", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 28 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.FatherName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 30 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.Birthdate));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 31 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.Birthdate, new { type = "date", @placeholder = "Date of birth", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 32 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.Birthdate, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 34 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.Mail));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 35 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.Mail, new { @placeholder = "Mail", @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 36 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.Mail, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 38 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.LabelFor(x => x.Mobile));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 39 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.TextBoxFor(x => x.Mobile, new { @placeholder = "Mobile Number", @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
#nullable restore
#line 40 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
       Write(Html.ValidationMessageFor(x => x.Mobile, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\r\n");
                WriteLiteral("            <input type=\"submit\" class=\"btn btn-success\" value=\"Add\">\r\n");
#nullable restore
#line 43 "C:\Users\ACER\Desktop\StudentManagementSystem\Course\Course\Views\Students\AddStudent.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Students> Html { get; private set; }
    }
}
#pragma warning restore 1591
