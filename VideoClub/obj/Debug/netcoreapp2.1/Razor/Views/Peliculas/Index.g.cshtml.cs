#pragma checksum "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0757ba21f24880f173373dd6ff38152d809f72ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peliculas_Index), @"mvc.1.0.view", @"/Views/Peliculas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peliculas/Index.cshtml", typeof(AspNetCore.Views_Peliculas_Index))]
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
#line 1 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\_ViewImports.cshtml"
using VideoClub;

#line default
#line hidden
#line 2 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\_ViewImports.cshtml"
using VideoClub.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0757ba21f24880f173373dd6ff38152d809f72ea", @"/Views/Peliculas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f378cab923ec00a7ef9a3a7680088778a6f84bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Peliculas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VideoClub.Models.Pelicula>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlquilarPelicula", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
  
    ViewData["Title"] = "Peliculas";

#line default
#line hidden
            BeginContext(94, 60, true);
            WriteLiteral("\r\n<h2>Peliculas</h2>\r\n\r\n<table class=\"table\">\r\n    <tbody>\r\n");
            EndContext();
#line 11 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(203, 91, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                <div><i class=\"fas fa-ticket-alt categoria\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 294, "\"", 350, 5);
            WriteAttributeValue("", 302, "color:", 302, 6, true);
#line 15 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
WriteAttributeValue(" ", 308, item.Categoria.Disenio, 309, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 332, ";", 332, 1, true);
            WriteAttributeValue(" ", 333, "font-size:", 334, 11, true);
            WriteAttributeValue(" ", 344, "20px;", 345, 6, true);
            EndWriteAttribute();
            BeginContext(351, 28, true);
            WriteLiteral("></i><div class=\"categoria\">");
            EndContext();
            BeginContext(380, 56, false);
#line 15 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                                                                                                                           Write(Html.DisplayFor(modelItem => item.Categoria.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(436, 110, true);
            WriteLiteral("</div></div>\r\n                <!--<div><div class=\"categoria\" style=\"width:30px;height:30px; background-color:");
            EndContext();
            BeginContext(547, 22, false);
#line 16 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                                                                           Write(item.Categoria.Disenio);

#line default
#line hidden
            EndContext();
            BeginContext(569, 112, true);
            WriteLiteral("; border-style: solid; border-color: black;\"></div>-->\r\n            </td>\r\n            <td>\r\n                <b>");
            EndContext();
            BeginContext(682, 41, false);
#line 19 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
              Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(723, 6, true);
            WriteLiteral("</b> (");
            EndContext();
            BeginContext(730, 50, false);
#line 19 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                                              Write(Html.DisplayFor(modelItem => item.AnioLanzamiento));

#line default
#line hidden
            EndContext();
            BeginContext(780, 25, true);
            WriteLiteral(")\r\n                <br />");
            EndContext();
            BeginContext(806, 86, false);
#line 20 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                 Write(Html.DisplayFor(modelItem => item.PeliculaGeneros.FirstOrDefault().Genero.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(892, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(896, 43, false);
#line 20 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Duracion));

#line default
#line hidden
            EndContext();
            BeginContext(939, 41, true);
            WriteLiteral(" MIN\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(980, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7901056b6bee4d54a11ee8962b0e0ba2", async() => {
                BeginContext(1028, 25, true);
                WriteLiteral("<button>Detalles</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1057, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1080, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d61c49618e5341ae9c707c8e6f2b5bc5", async() => {
                BeginContext(1137, 25, true);
                WriteLiteral("<button>Alquilar</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1166, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 25 "C:\Users\ferod\source\repos\VideoClub\VideoClub\Views\Peliculas\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1199, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VideoClub.Models.Pelicula>> Html { get; private set; }
    }
}
#pragma warning restore 1591
