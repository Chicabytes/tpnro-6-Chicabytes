#pragma checksum "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "738e033e0d82e214d480e8b7fe9ceb31a9e8d664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index2), @"mvc.1.0.view", @"/Views/Pedido/Index2.cshtml")]
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
#line 1 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\_ViewImports.cshtml"
using tp6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\_ViewImports.cshtml"
using tp6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"738e033e0d82e214d480e8b7fe9ceb31a9e8d664", @"/Views/Pedido/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d818f7a0d6dab1eb21ec11c47ce82dbeba0c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tp6.Pedido>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card\">\r\n    <div class=\"header pt-3 blue-gradient\">\r\n\r\n        <div class=\"row d-flex justify-content-center\">\r\n            <h3 class=\"white-text mb-3 pt-3 font-weight-bold\">Agregar Pedido</h3>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"</div>
<br />
<div class=""card"">
    <div class=""header pt-3 blue-gradient"">
        <div class=""row d-flex justify-content-center"">
            <h3 class=""white-text mb-3 pt-3 font-weight-bold"">Lista de Pedidos</h3>
        </div>
    </div>
    <div class=""card-body mx-4 mt-4"">
        <table class=""table"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th class=""th-sm"">ID</th>
                    <th class=""th-sm"">Cliente</th>
                    <th class=""th-sm"">Detalle</th>
                    <th class=""th-sm"">Cadete</th>
                    <th class=""th-sm"">Estado</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 67 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                 foreach (var Pedido in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 70 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                                        Write(Pedido.Numpedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 71 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                                        Write(Pedido.NCliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 72 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                                        Write(Pedido.Obs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 73 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                                        Write(Pedido.Cadete.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"align-middle\">");
#nullable restore
#line 74 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                                        Write(Pedido.Estado_actual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 76 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index2.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tp6.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591
