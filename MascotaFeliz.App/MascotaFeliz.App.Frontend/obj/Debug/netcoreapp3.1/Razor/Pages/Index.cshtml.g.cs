#pragma checksum "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c61c5b05c7468d087cc556a6c8ab98489e74461"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages
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
#line 1 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c61c5b05c7468d087cc556a6c8ab98489e74461", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main class=\"contenedor sombra\">\r\n        <div class=\"titulo\">\r\n            <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src= \"", 176, "\"", 215, 1);
#nullable restore
#line 9 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
WriteAttributeValue("", 183, Url.Content("~/img/huella.svg"), 183, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Huella\">\r\n            <h2>Bienvenido a Mascota Feliz SYS</h2>\r\n            <img class=\"titulo__imagen\"");
            BeginWriteAttribute("src", " src=\"", 324, "\"", 362, 1);
#nullable restore
#line 11 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
WriteAttributeValue("", 330, Url.Content("~/img/huella.svg"), 330, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Huella"">
        </div>
       
        <p class=""main__texto"">
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Explicabo libero, fugiat quo necessitatibus ea enim
            magnam vel! Necessitatibus quae ut nisi omnis! Laboriosam, repudiandae! Delectus aspernatur facilis repellat
            quaerat atque. Lorem ipsum dolor sit amet consectetur adipisicing elit. Est quia vitae ullam nemo possimus
            commodi minus ipsa sunt suscipit, velit, alias, quam necessitatibus exercitationem natus reiciendis non
            dolore laborum quas? Lorem ipsum dolor sit amet consectetur adipisicing elit. Minima, dolore laboriosam amet
            cum officiis quos perferendis dolorem quibusdam itaque vitae suscipit sapiente, non aliquid. Minima
            blanditiis ut repellendus voluptatem praesentium.
        </p>
        <div class=""main__imagen"">
            <img");
            BeginWriteAttribute("src", " src=\"", 1282, "\"", 1318, 1);
#nullable restore
#line 24 "C:\Mascotas\MascotaFeliz.App\MascotaFeliz.App.Frontend\Pages\Index.cshtml"
WriteAttributeValue("", 1288, Url.Content("~/img/cats.png"), 1288, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Imagen de bienvenida\">\r\n        </div>\r\n    </main>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
