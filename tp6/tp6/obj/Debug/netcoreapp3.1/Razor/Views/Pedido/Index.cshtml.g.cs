#pragma checksum "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ef27290eddf03370c41b20398713149b4ca6371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedido_Index), @"mvc.1.0.view", @"/Views/Pedido/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ef27290eddf03370c41b20398713149b4ca6371", @"/Views/Pedido/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d818f7a0d6dab1eb21ec11c47ce82dbeba0c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedido_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<tp6.ViewModel.PedidoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModificarPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BajaPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AltaPedido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<br />
<div class=""card"">
    <div class=""header pt-3 peach-gradient"">
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
#line 21 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                 foreach (var Pedido in Model.ListadoDePedidos)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 24 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                                            Write(Pedido.Numpedido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 25 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                                            Write(Pedido.NCliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 26 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                                            Write(Pedido.Obs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 27 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                                            Write(Pedido.Cadete.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">");
#nullable restore
#line 28 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                                            Write(Pedido.Estado_actual);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td class=\"align-middle\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef27290eddf03370c41b20398713149b4ca63718479", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"_idPedido\"");
                BeginWriteAttribute("value", " value=\"", 1444, "\"", 1469, 1);
#nullable restore
#line 31 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1452, Pedido.Numpedido, 1452, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-outline-info waves-effect\">✏️</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"align-middle\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef27290eddf03370c41b20398713149b4ca637110981", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"idPed\"");
                BeginWriteAttribute("value", " value=\"", 1865, "\"", 1890, 1);
#nullable restore
#line 37 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1873, Pedido.Numpedido, 1873, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <input type=\"hidden\" name=\"idCli\"");
                BeginWriteAttribute("value", " value=\"", 1961, "\"", 1988, 1);
#nullable restore
#line 38 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
WriteAttributeValue("", 1969, Pedido.NCliente.Id, 1969, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button type=\"submit\" class=\"btn btn-outline-danger waves-effect\">🗑️</button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 43 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 46 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
           if (ViewBag.UserLogueado == 2 || ViewBag.UserLogueado == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ef27290eddf03370c41b20398713149b4ca637114523", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"btn btn-outline-warning waves-effect\">Nuevo Pedido</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Pedido\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tp6.ViewModel.PedidoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
