#pragma checksum "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2070ce0a2edac34563f5238e36d8ecb78751268"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cadete_Index), @"mvc.1.0.view", @"/Views/Cadete/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2070ce0a2edac34563f5238e36d8ecb78751268", @"/Views/Cadete/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d818f7a0d6dab1eb21ec11c47ce82dbeba0c282", @"/Views/_ViewImports.cshtml")]
    public class Views_Cadete_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<tp6.ViewModel.CadeteViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GestionDePedidos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ModificarCadete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BajaCadete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aps-method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AltaCadete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
    <div class=""header pt-3 blue-gradient"">
        <div class=""row d-flex justify-content-center"">
            <h3 class=""white-text mb-3 pt-3 font-weight-bold"">Lista de Cadetes</h3>
        </div>
    </div>
    <div class=""card-body mx-4 mt-4"">
        <table id=""tablita"" class=""table"" cellspacing=""0"" width=""100%"">
            <thead>
                <tr>
                    <th class=""th-sm"">ID</th>
                    <th class=""th-sm"">Nombre</th>
                    <th class=""th-sm"">Direccion</th>
                    <th class=""th-sm"">Telefono</th>
                    <th class=""th-sm"">Vehiculo</th>
                    <th class=""th-sm"">Pedidos</th>
                    <th class=""th-sm"">Modificar</th>
                    <th class=""th-sm"">Eliminar</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 24 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                   foreach (var Cadete in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 27 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                           Write(Cadete.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 28 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                           Write(Cadete.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 29 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                           Write(Cadete.Direccion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 30 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                           Write(Cadete.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                           Write(Cadete.TipoT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2070ce0a2edac34563f5238e36d8ecb787512688755", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"idCadete\"");
                BeginWriteAttribute("value", " value=\"", 1502, "\"", 1520, 1);
#nullable restore
#line 34 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
WriteAttributeValue("", 1510, Cadete.Id, 1510, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <input type=\"hidden\" name=\"Tipo\"");
                BeginWriteAttribute("value", " value=\"", 1594, "\"", 1615, 1);
#nullable restore
#line 35 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
WriteAttributeValue("", 1602, Cadete.TipoT, 1602, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-outline-secondary waves-effect\">Gestionar Pedidos</button>\r\n                                ");
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
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2070ce0a2edac34563f5238e36d8ecb7875126811794", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"_id\"");
                BeginWriteAttribute("value", " value=\"", 2033, "\"", 2051, 1);
#nullable restore
#line 41 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
WriteAttributeValue("", 2041, Cadete.Id, 2041, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-outline-info waves-effect\">✏️</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2070ce0a2edac34563f5238e36d8ecb7875126814285", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"_id\"");
                BeginWriteAttribute("value", " value=\"", 2448, "\"", 2466, 1);
#nullable restore
#line 47 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
WriteAttributeValue("", 2456, Cadete.Id, 2456, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-outline-danger waves-effect\">🗑️</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\giuli\Documents\Facultad\SEGUNDO AÑO\Segundo Cuatrimestre\Taller2\Trabajos Practicos\tpnro-6-Chicabytes\tp6\tp6\Views\Cadete\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2070ce0a2edac34563f5238e36d8ecb7875126816979", async() => {
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-outline-info waves-effect\">Agregar Cadete</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<tp6.ViewModel.CadeteViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
