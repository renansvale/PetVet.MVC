#pragma checksum "C:\Users\recim\Desktop\Senac Renan\1 semestre\Módulo A - UC05 - Codificar Aplicações Web\Atividade 03\petvet\Views\Home\Servico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d05e0969dff618b7d483fc7f8050b24abad36daf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servico), @"mvc.1.0.view", @"/Views/Home/Servico.cshtml")]
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
#line 1 "C:\Users\recim\Desktop\Senac Renan\1 semestre\Módulo A - UC05 - Codificar Aplicações Web\Atividade 03\petvet\Views\_ViewImports.cshtml"
using petvet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\recim\Desktop\Senac Renan\1 semestre\Módulo A - UC05 - Codificar Aplicações Web\Atividade 03\petvet\Views\_ViewImports.cshtml"
using petvet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d05e0969dff618b7d483fc7f8050b24abad36daf", @"/Views/Home/Servico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b311e5a12d3866784a70519f9b1262f78e81e014", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servico : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InfoAgenda>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\recim\Desktop\Senac Renan\1 semestre\Módulo A - UC05 - Codificar Aplicações Web\Atividade 03\petvet\Views\Home\Servico.cshtml"
  
    ViewData["Title"] = "Serviço";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\recim\Desktop\Senac Renan\1 semestre\Módulo A - UC05 - Codificar Aplicações Web\Atividade 03\petvet\Views\Home\Servico.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<ul>
    <li>Consulta
        <ul>
            <li>Descrição do serviço 1</li>
            <li>Valor R$ 145,00</li>
        </ul>
    </li>
    <li>Castração
        <ul>
            <li>Descrição do serviço 2</li>
            <li>Valor R$ 180,00</li>
        </ul>
    </li>
    <li>Vacinas
        <ul>
            <li>Descrição do serviço 3</li>
            <li>Valor R$ 200,00</li>
        </ul>
    </li>
    <li>Pet Shopp
        <ul>
            <li>Descrição do serviço 4</li>
            <li>Valor R$ 100,00</li>
        </ul>
    </li>
</ul>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InfoAgenda> Html { get; private set; }
    }
}
#pragma warning restore 1591
