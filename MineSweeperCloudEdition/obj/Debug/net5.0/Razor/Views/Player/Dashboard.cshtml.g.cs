#pragma checksum "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c65159b67c9eaab7b87f43c8a86d5fa4649b563"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Player_Dashboard), @"mvc.1.0.view", @"/Views/Player/Dashboard.cshtml")]
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
#line 1 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\_ViewImports.cshtml"
using MineSweeperCloudEdition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\_ViewImports.cshtml"
using MineSweeperCloudEdition.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c65159b67c9eaab7b87f43c8a86d5fa4649b563", @"/Views/Player/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3cf7d70561702afd93009d182c94071ebf902d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Player_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataAccessLayer.Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Dashboard</h1>\r\n<h6>/player/dashboard</h6>\r\n\r\n<div>\r\n    <h4>Player</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.PlayerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.PlayerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 78 "C:\Users\anoth\Documents\GitHub\MineSweeperCloudEdition\MineSweeperCloudEdition\Views\Player\Dashboard.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    <!-- <a asp-action=\"Index\">Back to List</a> -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataAccessLayer.Player> Html { get; private set; }
    }
}
#pragma warning restore 1591