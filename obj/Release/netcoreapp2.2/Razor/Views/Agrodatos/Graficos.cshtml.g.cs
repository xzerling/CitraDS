#pragma checksum "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c2a091236339de8600dcf8dcf9576f9077de2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Agrodatos_Graficos), @"mvc.1.0.view", @"/Views/Agrodatos/Graficos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Agrodatos/Graficos.cshtml", typeof(AspNetCore.Views_Agrodatos_Graficos))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c2a091236339de8600dcf8dcf9576f9077de2d", @"/Views/Agrodatos/Graficos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Agrodatos_Graficos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CitraDataStore.Models.Agrodatos>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/npmlib/chart.js/dist/Chart.bundle.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/npmlib/chartjs-plugin-zoom/dist/chartjs-plugin-zoom.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/npmlib/hammerjs/hammer.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(161, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(171, 447, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d5005", async() => {
                BeginContext(177, 145, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Graficos</title>\r\n    <!-- Geoblaze -->\r\n    ");
                EndContext();
                BeginContext(322, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d5545", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(384, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(390, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d6798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(470, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(476, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d8051", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(527, 84, true);
                WriteLiteral("\r\n    <script src=\"https://momentjs.com/downloads/moment.min.js\"></script>\r\n\r\n\r\n\r\n\r\n");
                EndContext();
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
            EndContext();
            BeginContext(618, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(624, 1262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d10204", async() => {
                BeginContext(630, 246, true);
                WriteLiteral("\r\n    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <strong class=\"panel-title\">Grafico de datos disponibles</strong>\r\n\r\n            <select id=\"select1\" name=\"select1\" class=\"form-control\">\r\n                ");
                EndContext();
                BeginContext(876, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d10854", async() => {
                    BeginContext(884, 23, true);
                    WriteLiteral("Selecionar una estación");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(916, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 31 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(983, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1003, 117, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6c2a091236339de8600dcf8dcf9576f9077de2d12446", async() => {
                    BeginContext(1060, 1, true);
                    WriteLiteral(" ");
                    EndContext();
                    BeginContext(1062, 49, false);
#line 33 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
                                                                         Write(Html.DisplayFor(modelItem => item.NombreEstacion));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 33 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
                      WriteLiteral(Html.DisplayTextFor(modelItem => item.Id));

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
                BeginContext(1120, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 34 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
                }

#line default
#line hidden
                BeginContext(1141, 738, true);
                WriteLiteral(@"
            </select>

            <input type=""date"" id=""fechaI"" name=""fechaI"" class=""form-control"" placeholder=""Fecha de inicio"">
            <span class=""help-block"">Ingresar fecha de inicio</span>

            <input type=""date"" id=""fechaT"" name=""fechaT"" class=""form-control"" placeholder=""Fecha de Termino"">
            <span class=""help-block"">Ingresar fecha de Termino</span>

            <button type=""submit"" class=""btn btn-success"" id=""graficar"" onclick=""dibujarGrafico()"">
                <i class=""fa fa-dot-circle-o""></i> Graficar
            </button>
        </div>

        <div class=""panel-body"">

            <canvas id=""line-chart"" width=""800"" height=""450""></canvas>

        </div>

    </div>

");
                EndContext();
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
            EndContext();
            BeginContext(1886, 950, true);
            WriteLiteral(@"
</html>


<script>
    function dibujarGrafico() {
        console.log(""holamundo"");

        var estacion = document.getElementById(""select1"").value; //id del imput de seleccion
        var fechaI = document.getElementById(""fechaI"").value;
        var fechaT = document.getElementById(""fechaT"").value;

        var fecha1 = moment(fechaI);
        var fecha2 = moment(fechaT);

        var diasEntreFechas = fecha2.diff(fecha1, 'days');

        


        console.log(""comparar fechas"", fechaI > fechaT)
        if (fechaI > fechaT) {
            alert(""Fecha de Termino es anterior a la de Inicio"");
        }
        else {

            getSensorNames(estacion, fechaI, fechaT);

        function getSensorNames(estacion, fechaI, fechaT) {

            console.log(""funcion y el id: "" + estacion, fechaI, fechaT);
            $.ajax(
                {
                    type: ""GET"",
                    url: '");
            EndContext();
            BeginContext(2837, 43, false);
#line 91 "C:\Users\pfuen\Documents\GitKrakenRepo\CitraDS\Views\Agrodatos\Graficos.cshtml"
                     Write(Url.Action("ValorPiranometro", "AgroDatos"));

#line default
#line hidden
            EndContext();
            BeginContext(2880, 5013, true);
            WriteLiteral(@"',
                    data: {
                        estacion: estacion,
                        fechaI: fechaI,
                        fechaT: fechaT
                    },
                    dataType: ""json"",
                    contentType: ""application/json; charset=utf-8"",
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
          ");
            WriteLiteral(@"              } else if (exception === 'abort') {
                            msg = 'Ajax request aborted.';
                        } else {
                            msg = 'Uncaught Error.\n' + jqXHR.responseText;
                        }
                        alert(""error"");
                        console.log(msg);
                    },


                    success: function (data, status, result, lista) {
                        //console.log(""length de los datos: "", data.datos.length());
                        console.log(""objetcta.values(data)"", Object.values(data));
                        console.log(""cantidad de entradas: "", Object.values(data).length);
                        //console.log(""data: "", data[0].fecha)

                        var labels = data.map(function (e) {
                            return e.fecha;
                        });
                        var datos = data.map(function (e) {
                            return e.valor;
                      ");
            WriteLiteral(@"  });;


                        new Chart(document.getElementById(""line-chart""), {
                            type: 'line',
                            data: {
                                labels: labels,
                                datasets: [{
                                    data: datos,
                                    label: ""Rad W/m2"",
                                    fill: true,
                                    backgroundColor: 'rgba(0, 119, 204, 0.3)'

                                }
                                ]
                            },

                            options: {
                                title: {
                                    display: true,
                                    text: 'Valor de Radiacion Medido por piranometro al mediodia'
                                },
                                scales: {
                                    xAxes: [{
                                        ticks: {
            ");
            WriteLiteral(@"                                beginAtZero: true
                                        }
                                    }]
                                },
                                plugins: {
                                    zoom: {
                                        // Container for pan options
                                        pan: {
                                            // Boolean to enable panning
                                            enabled: true,

                                            // Panning directions. Remove the appropriate direction to disable
                                            // Eg. 'y' would only allow panning in the y direction
                                            mode: 'x'
                                        },

                                        // Container for zoom options
                                        zoom: {
                                            // Boolean to enable zooming
    ");
            WriteLiteral(@"                                        enabled: true,

                                            // Zooming directions. Remove the appropriate direction to disable
                                            // Eg. 'y' would only allow zooming in the y direction
                                            mode: 'x',
                                        }
                                    }
                                }
                            }
                        });

                        if (diasEntreFechas == Object.values(data).length)
                        {
                            alert(""DIFFFF"")
                        }
                        //alert(Object.values(data) + ""\nStatus: "" + status);
                        //console.log(data.length);
                    }
                })
        }
        }




    }






</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CitraDataStore.Models.Agrodatos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
