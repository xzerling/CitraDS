#pragma checksum "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b65c0d2fd110a4cf7490f86cd7c5ba41b673f1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstacionesAsignadas_Index), @"mvc.1.0.view", @"/Views/EstacionesAsignadas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstacionesAsignadas/Index.cshtml", typeof(AspNetCore.Views_EstacionesAsignadas_Index))]
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
#line 1 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore;

#line default
#line hidden
#line 2 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b65c0d2fd110a4cf7490f86cd7c5ba41b673f1c", @"/Views/EstacionesAsignadas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_EstacionesAsignadas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CitraDataStore.Models.Estacioneve>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
  
    ViewData["Title"] = "Estaciones Metereologicas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 93, true);
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(257, 17, false);
#line 10 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(274, 790, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Estaciones disponibles</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nombre</th>
                                <th>Accion</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 32 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1153, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1274, 37, false);
#line 36 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 127, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1439, 41, false);
#line 39 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1609, "\"", 1653, 2);
            WriteAttributeValue("", 1616, "/EstacionesAsignadas/Asignar/", 1616, 29, true);
#line 42 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
WriteAttributeValue("", 1645, item.Id, 1645, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1654, 96, true);
            WriteLiteral(">Asignar</a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 45 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\EstacionesAsignadas\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(1781, 432, true);
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</section>

<script>
    $(function () {
        $('#example2').DataTable({
            'paging': true,
            'lengthChange': false,
            'searching': false,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CitraDataStore.Models.Estacioneve>> Html { get; private set; }
    }
}
#pragma warning restore 1591
