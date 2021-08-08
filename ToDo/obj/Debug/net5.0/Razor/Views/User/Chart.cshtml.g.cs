#pragma checksum "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd65463d8d3a41d231d2fa270699d220bd64a8aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Chart), @"mvc.1.0.view", @"/Views/User/Chart.cshtml")]
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
#line 1 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\_ViewImports.cshtml"
using ToDo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
using ToDo.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd65463d8d3a41d231d2fa270699d220bd64a8aa", @"/Views/User/Chart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24dbfa247bf4efcab4de47a8cd07946aafc5d6b3", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Chart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd65463d8d3a41d231d2fa270699d220bd64a8aa3549", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <script src=\"https://canvasjs.com/assets/script/canvasjs.min.js\"></script>\r\n    <title>Index</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd65463d8d3a41d231d2fa270699d220bd64a8aa4692", async() => {
                WriteLiteral(@"
    <div id=""chartContainer"" style=""width: 60%; height: 300px;display: inline-block;""></div>
    <br /><br />
    <div id=""chartContainer2"" style=""width: 60%; height: 300px;display: inline-block;""></div>
    <br /><br />
    <div id=""chartContainer3"" style=""width: 60%; height: 300px;display: inline-block;""></div>

    <script type=""text/javascript"">

		window.onload = function () {
			var chart = new CanvasJS.Chart(""chartContainer"", {
                axisY: {
                    title: ""Amount"",
                    interlacedColor: ""#F8F1E4"",
                    tickLength: 10
				},
				axisX: {
					title: ""Type of Task""
                },
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""Amount of tasks""
				},
				subtitles: [
					{ text: """" }
				],
				data: [
				{
					type: ""column"", //change type to bar, line, area, pie, etc
					dataPoints: [
						{ y: ");
#nullable restore
#line 43 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
                        Write(ViewBag.DataPoints.Length);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"Total tasks remaining\" },\r\n\t\t\t\t\t\t{ y: ");
#nullable restore
#line 44 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
                        Write(ViewBag.HighPri.Length);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"High priority tasks remaining\" },\r\n\t\t\t\t\t\t{ y: ");
#nullable restore
#line 45 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
                        Write(ViewBag.LowPri.Length);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", label: ""Low priority tasks remaining""}

					]


				}
				]
			});



            var chart2 = new CanvasJS.Chart(""chartContainer2"", {
                axisY: {
                    title: ""Tasks added by day"",
                    interlacedColor: ""#F8F1E4"",
                    tickLength: 10
				},
				axisX: {
					title: ""Day""
                },
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""Tasks Added By Day""
				},
				subtitles: [
					{ text: """" }
				],
				data: [
				{
					type: ""column"", //change type to bar, line, area, pie, etc
					dataPoints: [
						{ y: ");
#nullable restore
#line 77 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
                        Write(ViewBag.Friday.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(", label: \"Friday\" },\r\n\t\t\t\t\t\t{ y: ");
#nullable restore
#line 78 "C:\Users\Shea Cooke\Desktop\LaunchCode\C#_Web_Development\ToDo_Project\ToDo\ToDo\Views\User\Chart.cshtml"
                        Write(ViewBag.Saturday.Count);

#line default
#line hidden
#nullable disable
                WriteLiteral(@", label: ""Saturday"" }


					]


				}
				]
			});


			var chart3 = new CanvasJS.Chart(""chartContainer3"", {
                axisY: {
                    title: ""Tasks completed by day"",
                    interlacedColor: ""#F8F1E4"",
                    tickLength: 10
				},
				axisX: {
					title: ""Day""
                },
				theme: ""light2"",
				animationEnabled: true,
				title: {
					text: ""Tasks Completed By Day""
				},
				subtitles: [
					{ text: """" }
				],
				data: [
				{
					type: ""column"", //change type to bar, line, area, pie, etc
					dataPoints: [
						{");
                WriteLiteral(" }\r\n\t\t\t\t\t\t\r\n\r\n\r\n\t\t\t\t\t]\r\n\r\n\r\n\t\t\t\t}\r\n\t\t\t\t]\r\n\t\t\t});\r\n\r\n\r\n            chart.render();\r\n\t\t\tchart2.render();\r\n            chart3.render();\r\n\r\n\r\n\r\n\t\t};\r\n    </script>\r\n\r\n\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>\t\t\t");
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
