#pragma checksum "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d0b0428f777c22a7e358999d1c7c02864a815c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CursoUsuarios_Disponibles), @"mvc.1.0.view", @"/Views/CursoUsuarios/Disponibles.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CursoUsuarios/Disponibles.cshtml", typeof(AspNetCore.Views_CursoUsuarios_Disponibles))]
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
#line 1 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\_ViewImports.cshtml"
using TpMVC;

#line default
#line hidden
#line 2 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\_ViewImports.cshtml"
using TpMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d0b0428f777c22a7e358999d1c7c02864a815c1", @"/Views/CursoUsuarios/Disponibles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ba808e5d0e7b00e97da702251a9dc540101b7b3", @"/Views/_ViewImports.cshtml")]
    public class Views_CursoUsuarios_Disponibles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TpMVC.Models.Curso>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "CursoUsuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 264, true);
            WriteLiteral(@"
<h2>Cursos disponibles</h2>

<input type=""text"" id=""myInput"" onkeyup=""myFunction()"" placeholder=""Buscar por lenguaje.."">
<hr/>

<table id=""myTable"" class=""table"">
    <thead class=""bg-secondary text-white"">
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(348, 42, false);
#line 16 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(390, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(446, 49, false);
#line 19 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.AnioPublicado));

#line default
#line hidden
            EndContext();
            BeginContext(495, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(551, 44, false);
#line 22 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Lenguaje));

#line default
#line hidden
            EndContext();
            BeginContext(595, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(651, 41, false);
#line 25 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayNameFor(model => model.Nivel));

#line default
#line hidden
            EndContext();
            BeginContext(692, 21, true);
            WriteLiteral("\r\n            </th>\r\n");
            EndContext();
#line 27 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
             if (User.IsInRole("cliente")) {

#line default
#line hidden
            BeginContext(759, 74, true);
            WriteLiteral("            <th>\r\n                Agrgar a Mis Cursos\r\n            </th>\r\n");
            EndContext();
#line 31 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
            }

#line default
#line hidden
            BeginContext(848, 42, true);
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 35 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(939, 11, true);
            WriteLiteral("        <tr");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 950, "\"", 989, 2);
            WriteAttributeValue("", 958, "background:", 958, 11, true);
#line 37 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
WriteAttributeValue("", 969, item.Nivel.ClaseCss, 969, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(990, 37, true);
            WriteLiteral(">\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1028, 41, false);
#line 39 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayFor(modelItem => item.Titulo));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1125, 48, false);
#line 42 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnioPublicado));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1229, 50, false);
#line 45 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayFor(modelItem => item.Lenguaje.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1335, 47, false);
#line 48 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nivel.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1382, 21, true);
            WriteLiteral("\r\n            </td>\r\n");
            EndContext();
#line 50 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
             if (User.IsInRole("cliente"))
            {

#line default
#line hidden
            BeginContext(1462, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(1504, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8eb99ba2920b4904b2600929e600345b", async() => {
                BeginContext(1582, 12, true);
                WriteLiteral(" - Agregar -");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
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
            BeginContext(1598, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 55 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
            }

#line default
#line hidden
            BeginContext(1638, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Compumar\Desktop\ORT\Proyects\TpMVC\Views\CursoUsuarios\Disponibles.cshtml"
        }

#line default
#line hidden
            BeginContext(1668, 703, true);
            WriteLiteral(@"    </tbody>
</table>

<script>
function myFunction() {

  var input, filter, table, tr, td, i, txtValue;
  input = document.getElementById(""myInput"");
  filter = input.value.toUpperCase();
  table = document.getElementById(""myTable"");
  tr = table.getElementsByTagName(""tr"");

  // Loop through all table rows, and hide those who don't match the search query
  for (i = 0; i < tr.length; i++) {
    td = tr[i].getElementsByTagName(""td"")[2];
    if (td) {
      txtValue = td.textContent || td.innerText;
      if (txtValue.toUpperCase().indexOf(filter) > -1) {
        tr[i].style.display = """";
      } else {
        tr[i].style.display = ""none"";
      }
    }
  }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TpMVC.Models.Curso>> Html { get; private set; }
    }
}
#pragma warning restore 1591