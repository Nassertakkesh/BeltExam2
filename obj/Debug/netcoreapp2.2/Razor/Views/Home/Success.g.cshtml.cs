#pragma checksum "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b45242c3e0cb091d267a6e5268d9c972b5138fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
#line 1 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/_ViewImports.cshtml"
using Exam2;

#line default
#line hidden
#line 2 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/_ViewImports.cshtml"
using Exam2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b45242c3e0cb091d267a6e5268d9c972b5138fb", @"/Views/Home/Success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e098b516698c4c5922c1cc0f0dd392a04227191", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActivityDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Join", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Leave", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("float-right btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewActivity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(42, 76, true);
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome to the Exam 2, ");
            EndContext();
            BeginContext(119, 26, false);
#line 6 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                            Write(ViewBag.ThisUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(145, 490, true);
            WriteLiteral(@"</h1>

</div>

<!-- <a class = ""float-right btn btn-primary""asp-controller=""home"" asp-action=""logout"" >
         Logout
        </a> -->
        <h1></h1>
<br>
<table class=""table"">

  <thead>
    <tr>
        <th scope=""col""> Activity</th>
        <th scope=""col""> Date and Time</th>
        <th scope=""col""> Duration</th>
        <th scope=""col""> Event Creator</th>
        <th scope=""col""> Number of Participants</th> 
        <th scope=""col""> Action</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 28 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
      foreach(var ThisActivity in @ViewBag.allTheWeddings)
      {

#line default
#line hidden
            BeginContext(702, 31, true);
            WriteLiteral("    <tr>\n        \n      <td>   ");
            EndContext();
            BeginContext(733, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b45242c3e0cb091d267a6e5268d9c972b5138fb7107", async() => {
                BeginContext(828, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(838, 18, false);
#line 33 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
   Write(ThisActivity.Title);

#line default
#line hidden
                EndContext();
                BeginContext(856, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 32 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                                                    WriteLiteral(ThisActivity.ActivityId);

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
            BeginContext(861, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(880, 25, false);
#line 34 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
       Write(ThisActivity.ActivityDate);

#line default
#line hidden
            EndContext();
            BeginContext(905, 19, true);
            WriteLiteral(" </td>\n        <td>");
            EndContext();
            BeginContext(925, 21, false);
#line 35 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
       Write(ThisActivity.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(946, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(948, 21, false);
#line 35 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                              Write(ThisActivity.TimeSpan);

#line default
#line hidden
            EndContext();
            BeginContext(969, 18, true);
            WriteLiteral("</td>\n        <td>");
            EndContext();
            BeginContext(988, 30, false);
#line 36 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
       Write(ThisActivity.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1018, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1020, 29, false);
#line 36 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                       Write(ThisActivity.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1049, 19, true);
            WriteLiteral(" </td>\n        <td>");
            EndContext();
            BeginContext(1069, 28, false);
#line 37 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
       Write(ThisActivity.Attendees.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 42, true);
            WriteLiteral(" </td>\n        <td>\n          \n          \n");
            EndContext();
#line 41 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
              int Guestidnum=0;

#line default
#line hidden
            BeginContext(1172, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 43 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
             if(ThisActivity.Creator.UserId  ==  @ViewBag.UID){

#line default
#line hidden
            BeginContext(1237, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1253, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b45242c3e0cb091d267a6e5268d9c972b5138fb12788", async() => {
                BeginContext(1346, 7, true);
                WriteLiteral("Delete ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                                                       WriteLiteral(ThisActivity.ActivityId);

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
            BeginContext(1357, 2, true);
            WriteLiteral(" \n");
            EndContext();
#line 45 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
            }
            else
            {
                bool isGuestInList = false;
                foreach( var i in ThisActivity.Attendees )
                {
                    if(i.UserId == @ViewBag.UID)
                    {
                        isGuestInList = true;
                        Guestidnum = i.PlayerId;
                        break;
                        
                    }
                }
                if(isGuestInList == false)
                {

#line default
#line hidden
            BeginContext(1848, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1868, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b45242c3e0cb091d267a6e5268d9c972b5138fb16084", async() => {
                BeginContext(1951, 5, true);
                WriteLiteral("Join ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                                                 WriteLiteral(ThisActivity.ActivityId);

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
            BeginContext(1960, 2, true);
            WriteLiteral(" \n");
            EndContext();
#line 62 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2019, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2035, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b45242c3e0cb091d267a6e5268d9c972b5138fb18936", async() => {
                BeginContext(2106, 6, true);
                WriteLiteral("Leave ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                                                              WriteLiteral(Guestidnum);

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
            BeginContext(2116, 2, true);
            WriteLiteral(" \n");
            EndContext();
#line 66 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2150, 72, true);
            WriteLiteral("          \n          \n          \n          \n           </td>\n\n    </tr>\n");
            EndContext();
#line 75 "/Users/Nasser/Desktop/Coding_Dojo/C#/Week 1/EntityFramework/Exam2/Views/Home/Success.cshtml"
      }

#line default
#line hidden
            BeginContext(2230, 21, true);
            WriteLiteral("  </tbody>\n</table>\n\n");
            EndContext();
            BeginContext(2251, 133, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b45242c3e0cb091d267a6e5268d9c972b5138fb22073", async() => {
                BeginContext(2342, 38, true);
                WriteLiteral("\n         Add a New Activity!\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2384, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591