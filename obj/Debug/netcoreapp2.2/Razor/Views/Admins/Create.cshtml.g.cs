#pragma checksum "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0797260860fc520f1043639b877bd2a97d94d9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admins_Create), @"mvc.1.0.view", @"/Views/Admins/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admins/Create.cshtml", typeof(AspNetCore.Views_Admins_Create))]
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
#line 1 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore;

#line default
#line hidden
#line 2 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\_ViewImports.cshtml"
using CitraDataStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0797260860fc520f1043639b877bd2a97d94d9f", @"/Views/Admins/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685786d528591fe38a675b867e37c0bea3782889", @"/Views/_ViewImports.cshtml")]
    public class Views_Admins_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CitraDataStore.Models.Admins>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Admins/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("content container-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml"
  
    ViewData["Title"] = "Crear Usuario";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(191, 187, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n\r\n\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(379, 17, false);
#line 16 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(396, 48, true);
            WriteLiteral("\r\n    </h1>\r\n</section>\r\n<!-- Main content -->\r\n");
            EndContext();
            BeginContext(444, 2726, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0797260860fc520f1043639b877bd2a97d94d9f6044", async() => {
                BeginContext(482, 415, true);
                WriteLiteral(@"
    <div class=""row"">
        <!-- left column -->
        <div class=""col-md-12"">
            <!-- general form elements -->
            <div class=""box box-primary"">
                <div class=""box-header with-border"">
                    <h3 class=""box-title"">Agregar Nuevo Usuario</h3>
                </div>
                <!-- /.box-header -->
                <!-- form start -->
                ");
                EndContext();
                BeginContext(897, 2186, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0797260860fc520f1043639b877bd2a97d94d9f6851", async() => {
                    BeginContext(941, 1030, true);
                    WriteLiteral(@"
                    <div onload=""console.log('The Script will load now.')"" class=""box-body"">
                        <div class=""form-group"">
                            <label for=""inputEmail3"">Nombre</label>
                            <input type=""text"" class=""form-control"" id=""FullName"" name=""FullName"" placeholder=""Nombre"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Email</label>
                            <input type=""email"" class=""form-control"" id=""Email"" name=""Email"" placeholder=""Escribir E-mail"">
                        </div>
                        <div class=""form-group"">
                            <label for=""exampleInputPassword1"">Password</label>
                            <input type=""password"" class=""form-control"" id=""Password"" name=""Password"" placeholder=""Escribir Password"">
                        </div>
                        <div class=""form-group"">
                      ");
                    WriteLiteral("      ");
                    EndContext();
                    BeginContext(1971, 55, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0797260860fc520f1043639b877bd2a97d94d9f8370", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 46 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RolesId);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2026, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(2057, 83, false);
#line 47 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml"
                       Write(Html.DropDownList("RolesId", null, htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
                    EndContext();
                    BeginContext(2140, 936, true);
                    WriteLiteral(@"
                        </div>

                        <div class=""form-group row"">
                            <label class=""col-md-3 col-form-label"">Estaciones Disponibles para asignar</label>
                            <div class=""col-md-9 col-form-label"" id=""divEstacion"">
                                <input class=""form-control"" type=""text"" placeholder=""No se han encontrado Estaciónes"" readonly>
                                <!--Aqui van los checkbox en funcion de la esacion seleccionada
                                    Son llamados en el script-->
                            </div>

                        </div>
                    </div>
                    <!-- /.box-body -->
                    <div class=""box-footer"">
                        <button type=""submit"" class=""btn btn-primary"">Crear</button>
                    </div>
                    <!-- /.box-footer -->
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3083, 80, true);
                WriteLiteral("\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n    </div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3170, 1038, true);
            WriteLiteral(@"

<script>

    //document.getElementById(""divEstacion"").onload() = function () { getStationsNames() }

    function getStationsNames() {


        var sensores = $('#divEstacion')[0];

        var childSize = sensores.childNodes.length;
        console.log(""chldSize: "" + childSize);
        var check = [];
        for (var i = 0; i < childSize; i++) {
            console.log(""ChildValue: "" + sensores.childNodes[i].childNodes[0].value);
            //console.log(""asdf: "" + sensores.childNodes[i].childNodes[0].checked);
            if (sensores.childNodes[i].childNodes[0].checked == false) {
                console.log(""ChildValue no sel: "" + sensores.childNodes[i].childNodes[0].value);
                check.push(sensores.childNodes[i].childNodes[0].value);
            }

            console.log(""tamaño arreglo: "" + check.length);
        }



      console.log(""funcion y el id: "");
      $.ajax(
        {
              type: ""GET"",
              data: {
              },
      ");
            WriteLiteral("        url: \'");
            EndContext();
            BeginContext(4209, 53, false);
#line 104 "C:\Users\Zerling\Documents\UTAL\2020-1\Citra\New\Git\CitraDS\Views\Admins\Create.cshtml"
               Write(Url.Action("NombreEstaciones", "EstacionesAsignadas"));

#line default
#line hidden
            EndContext();
            BeginContext(4262, 2331, true);
            WriteLiteral(@"',
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
                  } else if (exception === 'abort') {
                      msg = 'Ajax request aborted.';
                  } else {
                      msg = 'Uncaught Error.\n' + jqXHR.responseText;
                  }
                  alert(""error"");
       ");
            WriteLiteral(@"           console.log(msg);
              },


              success: function (data, status, result, lista) {
            //console.log(data.lista.length())
            //console.log(Object.values(data));
            //console.log(lista);
            //alert(Object.values(data) + ""\nStatus: "" + status);
            //console.log(data.length);


                  if (data.length > 0) {
                      var checkBox = '<div class=""col-md-8 col-form-label"" id=""divEstacion"">';
                      checkBox += '<form class=""form-inline"">';
                      $.each(data, function (i, Estacion) {
                          checkBox += '<div class=""form-group"">'
                          checkBox += '<div class=""custom-control custom-checkbox custom-control-inline"">';
                          checkBox += '<input class=""custom-control-input"" type=""checkbox"" value = ""' + Estacion.id + '"" id = ""check' + i + '"">';
                          checkBox += '<label class=""custom-control-label"" fo");
            WriteLiteral(@"r= ""check' + i + '"">' + Estacion.nombreEstacion + '</label ></div></div>';
                      });
                      checkBox += '</form>';
                      $('#divEstacion').replaceWith(checkBox);
                  }
              }
          })
    }

</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitraDataStore.Models.Admins> Html { get; private set; }
    }
}
#pragma warning restore 1591
