#pragma checksum "C:\Mascotas\MascotaFeliz\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinarios\AgregarVeterinario.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ba8dbcaf6d5290f4b80cda1ac49f0b8b24a1ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Veterinarios.Pages_Veterinarios_AgregarVeterinario), @"mvc.1.0.razor-page", @"/Pages/Veterinarios/AgregarVeterinario.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.Veterinarios
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
#line 1 "C:\Mascotas\MascotaFeliz\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ba8dbcaf6d5290f4b80cda1ac49f0b8b24a1ed", @"/Pages/Veterinarios/AgregarVeterinario.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Veterinarios_AgregarVeterinario : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("formulario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<main class=\"contenedor sombra\">\r\n        <div class=\"titulo\">\r\n            <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 181, "\"", 219, 1);
#nullable restore
#line 7 "C:\Mascotas\MascotaFeliz\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinarios\AgregarVeterinario.cshtml"
WriteAttributeValue("", 187, Url.Content("~/img/huella.svg"), 187, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n            <h2>Veterinario</h2>\r\n            <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 309, "\"", 347, 1);
#nullable restore
#line 9 "C:\Mascotas\MascotaFeliz\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\Veterinarios\AgregarVeterinario.cshtml"
WriteAttributeValue("", 315, Url.Content("~/img/huella.svg"), 315, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ba8dbcaf6d5290f4b80cda1ac49f0b8b24a1ed4999", async() => {
                WriteLiteral(@"
            <div class=""campos"">
                <div class=""campo"">
                    <label for=""id"" class=""campo__label"">Id:</label>
                    <input type=""text"" class=""campo__texto"" id=""id"" tabindex=""1"">
                </div>
                <div class=""campo"">
                    <label for=""nombre"" class=""campo__label"">Nombre:</label>
                    <input type=""text"" class=""campo__texto"" id=""nombre"" tabindex=""2"">
                </div>

                <div class=""campo"">
                    <label for=""apellido"" class=""campo__label"">Apellido:</label>
                    <input type=""text"" class=""campo__texto"" id=""apellido"" tabindex=""3"">
                </div>

                <div class=""campo"">
                    <label for=""direccion"" class=""campo__label"">Dirección:</label>
                    <input type=""text"" class=""campo__texto"" id=""direccion"" tabindex=""4"">
                </div>

                <div class=""campo"">
                    <label for=""telefo");
                WriteLiteral(@"no"" class=""campo__label"">Teléfono:</label>
                    <input type=""text"" class=""campo__texto"" id=""telefono"" tabindex=""5"">
                </div>
                <div class=""campo"">
                    <label for=""tarjeta"" class=""campo__label"">T Prof:</label>
                    <input type=""text"" class=""campo__texto"" id=""tarjeta"" tabindex=""6"">
                </div>
            </div>
            <div class=""botonera"">
                <input class=""boton"" type=""submit"" value=""Crear"">
                <input class=""boton"" type=""submit"" value=""Actualizar"">
                <input class=""boton"" type=""submit"" value=""Consultar"">
                <input class=""boton"" type=""submit"" value=""Borrar"">
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n        \r\n    </main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.AgregarVeterinarioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.AgregarVeterinarioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.AgregarVeterinarioModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.AgregarVeterinarioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
