#pragma checksum "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317f6c2920ca1de11938f8d0b16351ca8c01703d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jogador_Index), @"mvc.1.0.view", @"/Views/Jogador/Index.cshtml")]
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
#line 1 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\_ViewImports.cshtml"
using E_Players_AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\_ViewImports.cshtml"
using E_Players_AspNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317f6c2920ca1de11938f8d0b16351ca8c01703d", @"/Views/Jogador/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca473158da1b9ca79f248b6107b5531e73b6d86b", @"/Views/_ViewImports.cshtml")]
    public class Views_Jogador_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Jogador>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
  
    ViewData["Title"] = "Jogadores";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"titulo_pagina\">\r\n        <h1>cadastro de ");
#nullable restore
#line 7 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
                   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "317f6c2920ca1de11938f8d0b16351ca8c01703d4433", async() => {
                WriteLiteral(@"

    <div class=""campo"">
        <label>ID Jogador</label>
        <input type=""text"" name=""IdJogador"" />
    </div>

    <div class=""campo"">
        <label>ID Equipe</label>
        <input type=""text"" name=""IdEquipe"" />
    </div>

    <div class=""campo"">
        <label>Nome</label>
        <input type=""text"" name=""Nome"" />
    </div>

    <div class=""campo"">
        <label>Email</label>
        <input type=""text"" name=""Email"" />
    </div>

    <div class=""campo"">
        <label>Senha</label>
        <input type=""password"" name=""Senha"" />
    </div>

    <button class=""gradient btn"" type=""submit"">Cadastrar</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#nullable restore
#line 10 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
AddHtmlAttributeValue("", 187, Url.Action("Cadastrar"), 187, 24, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<table class=\"table table-striped table-responsive\">\r\n    <thead>\r\n        <th>ID</th>\r\n        <th>Nome</th>\r\n        <th>Email</th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
         foreach(Jogador j in ViewBag.players){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 49 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
               Write(j.IdJogador);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 50 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
               Write(j.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
               Write(j.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 53 "E:\Meus Documentos\Área de Trabalho\E-Players_AspNetCore\Views\Jogador\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Jogador> Html { get; private set; }
    }
}
#pragma warning restore 1591
