#pragma checksum "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b726dd9bc00a750c317b28fea7201105af86e78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jake_GameLog), @"mvc.1.0.view", @"/Views/Jake/GameLog.cshtml")]
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
#line 1 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\_ViewImports.cshtml"
using ApexStatTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\_ViewImports.cshtml"
using ApexStatTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b726dd9bc00a750c317b28fea7201105af86e78", @"/Views/Jake/GameLog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c529bf26598766b3542bd907af87b1b684cb7f31", @"/Views/_ViewImports.cshtml")]
    public class Views_Jake_GameLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApexStatTracker.Models.Jake>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
  
    ViewData["Title"] = "Jake Log";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Jake Game Log</h1>\r\n\r\n");
            WriteLiteral(@"

<table class=""content-table"">
    <thead>
        <tr>
            <th>
                Game Number
            </th>
            <th>
                &nbsp;&nbsp; Damage
            </th>
            <th>
                &nbsp;&nbsp; Kills
            </th>
            <th>
                &nbsp;&nbsp;Revives Given
            </th>
            <th>
                &nbsp;&nbsp; Respawns
            </th>
            <th>
                &nbsp;&nbsp; Times Revived 
            </th>
            <th>
                &nbsp;&nbsp;Game Score
            </th>
            <th></th>
        </tr>
    <tbody>
");
#nullable restore
#line 37 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
         foreach (var game in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
               Write(game.GameNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 41 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.Damage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 42 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.Kills);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 43 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.Revives);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 44 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.Respawns);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 45 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.Revived);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> &nbsp;&nbsp;");
#nullable restore
#line 46 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
                            Write(game.GameScore);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 48 "C:\Users\jlane\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Jake\GameLog.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    </thead>\r\n</table>\r\n\r\n\r\n<style>\r\n    ");
            WriteLiteral(@"@import url('https://fonts.googleapis.com/css?family=Titillium+Web&display=swap');

    h1 {
        text-align: center;
    }

    .content-table {
        border-collapse: collapse;
        margin: 25px 0;
        font-size: 1.6rem;
        min-width: 600px;
        border-radius: 10px 12px 0 0;
        box-shadow: 0 0 20px rgba(0,0,0, 0.15);
        background-color: chocolate;
        color: white;
        font-family: 'Raleway', sans-serif;
        font-weight: bold;
        line-height: 1.7;
        box-shadow: 10px 10px 5px grey;
        text-align: center;
    }

        .content-table thead tr {
            background-color: #f3f3f3;
            color: chocolate;
            text-align: center;
            font-weight: bolder;
        }

        .content-table th,
        content.content-table td {
            padding: 10px 1px;
        }

        .content-table tbody tr {
            border-bottom: 1px solid #dddddd
        }

            /*.content-table tbody ");
            WriteLiteral(@"tr:nth-of-type(even) {
                background-color: #f3f3f3;
                color: black;
            }*/

            /*.content-table tbody tr:last-of-type {
                border-bottom: 5px solid chocolate;
            }*/

            .content-table tbody tr.active row {
                font-weight: bold;
                color: coral;
            }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApexStatTracker.Models.Jake>> Html { get; private set; }
    }
}
#pragma warning restore 1591
