#pragma checksum "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbe549b0013e3a18cc21878bd3959e6a63073f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tutors_Index), @"mvc.1.0.view", @"/Views/Tutors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tutors/Index.cshtml", typeof(AspNetCore.Views_Tutors_Index))]
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
#line 1 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\_ViewImports.cshtml"
using WAD_8574;

#line default
#line hidden
#line 2 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\_ViewImports.cshtml"
using WAD_8574.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbe549b0013e3a18cc21878bd3959e6a63073f84", @"/Views/Tutors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cabf458f2feac8002fe925ed05afa138a4d4ab48", @"/Views/_ViewImports.cshtml")]
    public class Views_Tutors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WAD_8574.Models.SchoolViewModels.TutorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
  
    ViewData["Title"] = "Tutors";

#line default
#line hidden
            BeginContext(100, 30, true);
            WriteLiteral("\r\n<h2>Tutors</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(130, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "337acf93e5314c449022f683ade4a1a6", async() => {
                BeginContext(153, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(167, 256, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 23 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
         foreach (var item in Model.Tutors)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["TutorId"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(644, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 659, "\"", 679, 1);
#line 30 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
WriteAttributeValue("", 667, selectedRow, 667, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(680, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(726, 43, false);
#line 32 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(769, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(837, 47, false);
#line 35 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
            EndContext();
            BeginContext(884, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(952, 43, false);
#line 38 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
            EndContext();
            BeginContext(995, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 41 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                     if (item.OfficeAssignment != null)
                    {
                        

#line default
#line hidden
            BeginContext(1147, 30, false);
#line 43 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                   Write(item.OfficeAssignment.Location);

#line default
#line hidden
            EndContext();
#line 43 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                                       }

#line default
#line hidden
            BeginContext(1180, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 46 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                       foreach (var course in item.CourseAssignments)
                        {
                            

#line default
#line hidden
            BeginContext(1352, 22, false);
#line 48 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                       Write(course.Course.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(1374, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1377, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1379, 19, false);
#line 48 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                                  Write(course.Course.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1398, 9, true);
            WriteLiteral("  <br/>\r\n");
            EndContext();
#line 49 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                        } 

#line default
#line hidden
            BeginContext(1436, 65, true);
            WriteLiteral("                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1501, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd15af5540ca49a0aa1b0b6e28d97d3a", async() => {
                BeginContext(1547, 6, true);
                WriteLiteral("Select");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 52 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                            WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1557, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1581, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8988426aba0e488ba70cf2d6fb8c6e2d", async() => {
                BeginContext(1626, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1634, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1658, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b014d16771db4e2eba3e10667895b81e", async() => {
                BeginContext(1706, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                              WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1717, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1741, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f144888c309e4c758d07cb5ce7db61da", async() => {
                BeginContext(1788, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1798, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 58 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1853, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
#line 62 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
            BeginContext(1911, 216, true);
            WriteLiteral("    <h3>Courses Taught by Selected Tutor</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Number</th>\r\n            <th>Title</th>\r\n            <th>Department</th>\r\n        </tr>\r\n");
            EndContext();
#line 72 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseId == (int?)ViewData["CourseId"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
            BeginContext(2356, 15, true);
            WriteLiteral("            <tr");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2371, "\"", 2391, 1);
#line 79 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
WriteAttributeValue("", 2379, selectedRow, 2379, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2392, 45, true);
            WriteLiteral(">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2438, 68, false);
#line 81 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new { courseId = item.CourseId }));

#line default
#line hidden
            EndContext();
            BeginContext(2506, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2574, 13, false);
#line 84 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(item.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(2587, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2655, 10, false);
#line 87 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2665, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2733, 20, false);
#line 90 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2753, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 93 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2808, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 95 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
}

#line default
#line hidden
#line 96 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
            BeginContext(2861, 178, true);
            WriteLiteral("    <h3>\r\n        Students Enrolled in Selected Course\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
            EndContext();
#line 106 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
            BeginContext(3100, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3161, 21, false);
#line 110 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(3182, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3250, 40, false);
#line 113 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(3290, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 116 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3345, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 118 "D:\zzz\WIUT\semseter 9\wad\WebApp\WAD.CW_ref.8574\WAD.CW_ref.8574\WAD_8574\Views\Tutors\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WAD_8574.Models.SchoolViewModels.TutorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591
