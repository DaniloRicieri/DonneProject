<<<<<<< HEAD
#pragma checksum "D:\thay_\Documents\Recode Pro\PROJETO\Entrega 2\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61f28cf728d19d84a6ee6b405098870f8e29f5b1"
=======
#pragma checksum "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300e1d15f3a186bf1ca1ed0730339e8a797a061e"
>>>>>>> ccc31e23ab241812e89e1edbf6a519fbe92e5ba8
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroSobrevs_Delete), @"mvc.1.0.view", @"/Views/CadastroSobrevs/Delete.cshtml")]
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
#line 1 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\_ViewImports.cshtml"
using DonneProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\_ViewImports.cshtml"
using DonneProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f28cf728d19d84a6ee6b405098870f8e29f5b1", @"/Views/CadastroSobrevs/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"506cf1196f162ef423e8e491c6b6e254ceeeba5d", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroSobrevs_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonneProject.Models.CadastroSobrev>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Delete</h1>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>CadastroSobrev</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 15 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 18 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 21 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 24 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 27 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 30 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.endereco));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 33 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 36 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 39 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeFuncao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 42 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NomeFuncao.NomeFuncao));

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\n        </dd class>\n    </dl>\n    \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f28cf728d19d84a6ee6b405098870f8e29f5b18390", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "61f28cf728d19d84a6ee6b405098870f8e29f5b18654", async() => {
=======
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300e1d15f3a186bf1ca1ed0730339e8a797a061e8390", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "300e1d15f3a186bf1ca1ed0730339e8a797a061e8656", async() => {
>>>>>>> ccc31e23ab241812e89e1edbf6a519fbe92e5ba8
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 47 "C:\Users\Rodrigo\Desktop\Projeto Donne v3\DonneProject\DonneProject\Views\CadastroSobrevs\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
<<<<<<< HEAD
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61f28cf728d19d84a6ee6b405098870f8e29f5b110466", async() => {
=======
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "300e1d15f3a186bf1ca1ed0730339e8a797a061e10466", async() => {
>>>>>>> ccc31e23ab241812e89e1edbf6a519fbe92e5ba8
                    WriteLiteral("Back to List");
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
                WriteLiteral("\n    ");
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
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DonneProject.Models.CadastroSobrev> Html { get; private set; }
    }
}
#pragma warning restore 1591
