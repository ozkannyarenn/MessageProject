#pragma checksum "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb3098b6e3b09b0a4edd2fa5dc7e259c76cace70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUser_List), @"mvc.1.0.view", @"/Views/ApplicationUser/List.cshtml")]
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
#line 1 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\_ViewImports.cshtml"
using Message.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\_ViewImports.cshtml"
using Message.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3098b6e3b09b0a4edd2fa5dc7e259c76cace70", @"/Views/ApplicationUser/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a871e9cff5155aa82de713c4bfae286e62fe112", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUser_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.PagedList<Message.Data.Domain.Entities.ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-striped table-hover"">
        <thead>
            <tr>
                <th></th>
                <th>Kullan??c?? Ad??</th>
                <th>Ad</th>
                <th>Soyad</th>
                <th>E-posta</th>
            </tr>
        </thead>
");
#nullable restore
#line 15 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    <div class=\"input-group-prepend\">\r\n                        <a class=\"btn btn-outline-secondary btn-sm\" title=\"Detay\"");
            BeginWriteAttribute("href", "\r\n                           href=\"", 618, "\"", 716, 1);
#nullable restore
#line 21 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
WriteAttributeValue("", 653, Url.Action("Details", "ApplicationUser", new { id = item.Id }), 653, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <i class=""fa fa-eye""></i>
                        </a>
                        <button type=""button"" class=""btn btn-outline-secondary dropdown-toggle dropdown-toggle-split btn-sm"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <span class=""sr-only"">Toggle Dropdown</span>
                        </button>
                        <div class=""dropdown-menu"">
                            <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 1212, "\"", 1279, 1);
#nullable restore
#line 28 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
WriteAttributeValue("", 1219, Url.Action("Edit", "ApplicationUser", new { id = item.Id }), 1219, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">G??ncelleme</a>\r\n                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1349, "\"", 1429, 1);
#nullable restore
#line 29 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
WriteAttributeValue("", 1356, Url.Action("ApplicationDelete", "ApplicationUser", new { id = item.Id }), 1356, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sil</a>\r\n                        </div>\r\n                    </div>\r\n                </td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 40 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-body\">\r\n        ");
#nullable restore
#line 44 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
   Write(await Html.PartialAsync("Error", "Kay??tl?? M????teri Yok!"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 46 "C:\Users\EysanGuc\source\repos\Message-Project\Message-Project\Message.Admin\Views\ApplicationUser\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.PagedList<Message.Data.Domain.Entities.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
