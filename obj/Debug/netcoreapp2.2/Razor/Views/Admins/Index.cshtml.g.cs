#pragma checksum "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bd633799a2325ad2dc1c6dff0b132805853ab7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Index), @"mvc.1.0.view", @"/Views/Admins/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Index.cshtml", typeof(AspNetCore.Views_Admins_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bd633799a2325ad2dc1c6dff0b132805853ab7e", @"/Views/Admins/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ViewModel>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
  
    ViewData["Title"] = "Usuarios";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(111, 185, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(297, 17, false);
#line 13 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(314, 978, true);
            WriteLiteral(@"
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Lista de Usuarios</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
                    <table id=""example2"" class=""table table-bordered table-hover"">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Nombre</th>
                                <th>Email</th>
                                <th>Rol</th>
                                <!--
                               <th>Estacion</th>
    -->
                                <th>Acciones</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 40 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                             foreach (Admins admins in Model.Admins)
                            {

#line default
#line hidden
            BeginContext(1393, 128, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1521, "\"", 1536, 1);
#line 44 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
WriteAttributeValue("", 1526, admins.Id, 1526, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1537, "\"", 1555, 1);
#line 44 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
WriteAttributeValue("", 1545, admins.Id, 1545, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1556, 48, true);
            WriteLiteral(" readonly>\r\n                                    ");
            EndContext();
            BeginContext(1605, 9, false);
#line 45 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                               Write(admins.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1614, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1730, 15, false);
#line 48 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                               Write(admins.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1745, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1861, 12, false);
#line 51 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                               Write(admins.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1873, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(1989, 18, false);
#line 54 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                               Write(admins.Roles.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2007, 128, true);
            WriteLiteral("\r\n                                </td>\r\n\r\n                                <!-- Asignar Estacion\r\n    <td>\r\n        <select id=\"");
            EndContext();
            BeginContext(2136, 9, false);
#line 59 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
               Write(admins.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2145, 8, true);
            WriteLiteral("\" name=\"");
            EndContext();
            BeginContext(2154, 9, false);
#line 59 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                                 Write(admins.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2163, 79, true);
            WriteLiteral("\" class=\"form-control\">\r\n            <option>Selecionar una estación</option>\r\n");
            EndContext();
#line 61 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
             foreach (Estacioneve agrodatos in Model.Agrodatos)
            {

#line default
#line hidden
            BeginContext(2322, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(2338, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bd633799a2325ad2dc1c6dff0b132805853ab7e9105", async() => {
                BeginContext(2366, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2368, 16, false);
#line 63 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                                        Write(agrodatos.Nombre);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                  WriteLiteral(agrodatos.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2393, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 64 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(2412, 108, true);
            WriteLiteral("        </select>\r\n        <button type=\"submit\" class=\"btn btn-success\" id=\"Asignar\" onclick=\"obtenerDatos(");
            EndContext();
            BeginContext(2521, 9, false);
#line 67 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                                                                                    Write(admins.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2530, 120, true);
            WriteLiteral(")\">Asignar</button>\r\n    </td>\r\n\r\n     -->\r\n                                <td>\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2650, "\"", 2680, 2);
            WriteAttributeValue("", 2657, "/Admins/Edit/", 2657, 13, true);
#line 72 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
WriteAttributeValue("", 2670, admins.Id, 2670, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2681, 53, true);
            WriteLiteral(">Editar</a> |\r\n                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2734, "\"", 2766, 2);
            WriteAttributeValue("", 2741, "/Admins/Delete/", 2741, 15, true);
#line 73 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
WriteAttributeValue("", 2756, admins.Id, 2756, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2767, 87, true);
            WriteLiteral(">Borrar</a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 76 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2885, 989, true);
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
    })</script>

<script>
    function obtenerDatos() {

        var id = document.getElementById(""select1"").value; //id del imput de seleccion
        var idUsuario = document.getElementById(""fecha2"").value; //id del imput de seleccion
            /*console.log(""SET FORMCONTROL"");
            console.log(""SET FORMCONTROLaaa"");
            console.log(""ID: ""+id);*/
            //getSensorNames(id);
        console.log(""valor: "" + id)
        console.log(""valorUsuario: "" + idUsuario)

        $.ajax(
        {
          type: ""POST"",
          url: """);
            EndContext();
            BeginContext(3875, 43, false);
#line 112 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Admins\Index.cshtml"
           Write(Url.Action("Create", "EstacionesAsignadas"));

#line default
#line hidden
            EndContext();
            BeginContext(3918, 1073, true);
            WriteLiteral(@""",
          data: {
              id: id,
              idUsuario: idUsuario
          },

          error: function (jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
              msg = 'Not connect.\n Verify Network.';
            } else if (jqXHR.status == 404) {
              msg = 'Requested page not found. [404]';
            } else if (jqXHR.status == 500) {
              msg = 'Internal Server Error [500].';
            } else if (exception === 'parsererror') {
              msg = 'Requested JSON parse failed.';
            } else if (exception === 'timeout') {
              msg = 'Time out error.';
            } else if (exception === 'abort') {
              msg = 'Ajax request aborted.';
            } else {
              msg = 'Uncaught Error.\n' + jqXHR.responseText;
            }
            alert(""error"");
            console.log(msg);
          },

          success:function (data, status) {
            console.log(""success"");
  ");
            WriteLiteral("          }\r\n          })\r\n\r\n\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
