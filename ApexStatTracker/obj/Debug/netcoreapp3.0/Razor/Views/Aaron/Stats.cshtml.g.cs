#pragma checksum "C:\Users\Jake\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Aaron\Stats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12df528d4f898ce1c279ac99417127820e969821"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Aaron_Stats), @"mvc.1.0.view", @"/Views/Aaron/Stats.cshtml")]
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
#line 1 "C:\Users\Jake\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\_ViewImports.cshtml"
using ApexStatTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jake\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\_ViewImports.cshtml"
using ApexStatTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12df528d4f898ce1c279ac99417127820e969821", @"/Views/Aaron/Stats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c529bf26598766b3542bd907af87b1b684cb7f31", @"/Views/_ViewImports.cshtml")]
    public class Views_Aaron_Stats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApexStatTracker.Models.Aaron>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jake\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Aaron\Stats.cshtml"
  
    ViewData["Title"] = "Stats";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Jake\Desktop\Projects\ApexStatTracker\ApexStatTracker\Views\Aaron\Stats.cshtml"
  
    ViewData["Title"] = "Aaron Log";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aaron Game Log</h1>\r\n\r\n");
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
                &nbsp;&nbsp;Revives
            </th>
            <th>
                &nbsp;&nbsp; Respawns
            </th>
            <th>
                &nbsp;&nbsp; Revived
            </th>
            <th>
                &nbsp;&nbsp;Game Score
            </th>
            <th></th>
        </tr>
    <tbody>
       
        
            <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
            </tr>
        
    </tbody>
    </thead>
</table>


<style>
    ");
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
</style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApexStatTracker.Models.Aaron>> Html { get; private set; }
    }
}
#pragma warning restore 1591
