#pragma checksum "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8da46c297244ed6ae1ee604196c1af3a5cfd3ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CursoUsuarios_EliminarUsuarioCurso), @"mvc.1.0.view", @"/Views/CursoUsuarios/EliminarUsuarioCurso.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CursoUsuarios/EliminarUsuarioCurso.cshtml", typeof(AspNetCore.Views_CursoUsuarios_EliminarUsuarioCurso))]
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
#line 1 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\_ViewImports.cshtml"
using TpMVC;

#line default
#line hidden
#line 2 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\_ViewImports.cshtml"
using TpMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8da46c297244ed6ae1ee604196c1af3a5cfd3ce", @"/Views/CursoUsuarios/EliminarUsuarioCurso.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba808e5d0e7b00e97da702251a9dc540101b7b3", @"/Views/_ViewImports.cshtml")]
    public class Views_CursoUsuarios_EliminarUsuarioCurso : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TpMVC.Models.CursoUsuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsuariosInscriptos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EliminarUsuarioCurso", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(78, 20, true);
            WriteLiteral("\r\n    <h2>Eliminar: ");
            EndContext();
            BeginContext(99, 20, false);
#line 7 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
             Write(Model.Usuario.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(119, 3, true);
            WriteLiteral("   ");
            EndContext();
            BeginContext(123, 22, false);
#line 7 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
                                     Write(Model.Usuario.Apellido);

#line default
#line hidden
            EndContext();
            BeginContext(145, 144, true);
            WriteLiteral(" del curso</h2>\r\n\r\n<h3>¿Estas seguro que quieres eliminarlo?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(290, 48, false);
#line 14 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayNameFor(model => model.Curso.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(338, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(382, 44, false);
#line 17 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(470, 50, false);
#line 20 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayNameFor(model => model.Curso.Profesor));

#line default
#line hidden
            EndContext();
            BeginContext(520, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(564, 53, false);
#line 23 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Profesor.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(617, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(661, 50, false);
#line 26 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayNameFor(model => model.Curso.Lenguaje));

#line default
#line hidden
            EndContext();
            BeginContext(711, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(755, 53, false);
#line 29 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayFor(model => model.Curso.Lenguaje.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(808, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(852, 57, false);
#line 32 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayNameFor(model => model.Curso.CantSubscriptos));

#line default
#line hidden
            EndContext();
            BeginContext(909, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(953, 53, false);
#line 35 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
       Write(Html.DisplayFor(model => model.Curso.CantSubscriptos));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 44, true);
            WriteLiteral("\r\n        </dd>\r\n        \r\n    </dl>\r\n\r\n    ");
            EndContext();
            BeginContext(1050, 253, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e599a01bdd64bd98260b29209146eb1", async() => {
                BeginContext(1090, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1100, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "69699751910f4334bfe50df3d0e96154", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 41 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC4\Views\CursoUsuarios\EliminarUsuarioCurso.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1136, 98, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"EliminarUsuarioCurso\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1234, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a54107a96a324380bfc81bca0fdf3e3d", async() => {
                    BeginContext(1269, 17, true);
                    WriteLiteral("Volver a la lista");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1290, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1303, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TpMVC.Models.CursoUsuario> Html { get; private set; }
    }
}
#pragma warning restore 1591