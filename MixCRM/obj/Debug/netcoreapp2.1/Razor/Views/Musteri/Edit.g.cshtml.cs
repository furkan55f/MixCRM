#pragma checksum "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb24e3881fe3c9dce9610155bf3deed616187c0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musteri_Edit), @"mvc.1.0.view", @"/Views/Musteri/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Musteri/Edit.cshtml", typeof(AspNetCore.Views_Musteri_Edit))]
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
#line 1 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM;

#line default
#line hidden
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\_ViewImports.cshtml"
using MixCRM.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb24e3881fe3c9dce9610155bf3deed616187c0c", @"/Views/Musteri/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4d003a1e69c72c5ad002022581ea7097e0e5d14", @"/Views/_ViewImports.cshtml")]
    public class Views_Musteri_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Musteri>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
  
    ViewData["Title"] = ViewBag.ActionMode; ;

#line default
#line hidden
            BeginContext(70, 123, true);
            WriteLiteral("\r\n<div class=\"m-4\">\r\n    <div class=\"bg-success text-white p-4\">\r\n        <h2>Müşteri Ekle / Düzenle</h2>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(193, 2920, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48faa21bb00a44a2aa7376d42028fab6", async() => {
                BeginContext(248, 49, true);
                WriteLiteral("\r\n        <input type=\"hidden\" name=\"original.Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 297, "\"", 314, 1);
#line 11 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 305, Model.Id, 305, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(315, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 369, "\"", 386, 1);
#line 12 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 377, Model.Ad, 377, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(387, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 441, "\"", 461, 1);
#line 13 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 449, Model.Soyad, 449, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(462, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 516, "\"", 539, 1);
#line 14 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 524, Model.TCKimlik, 524, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(540, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 594, "\"", 614, 1);
#line 15 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 602, Model.Email, 602, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(615, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 669, "\"", 692, 1);
#line 16 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 677, Model.Cinsiyet, 677, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(693, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 747, "\"", 768, 1);
#line 17 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 755, Model.DTarih, 755, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(769, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 823, "\"", 843, 1);
#line 18 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 831, Model.Adres, 831, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(844, 54, true);
                WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"original.Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 898, "\"", 918, 1);
#line 19 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
WriteAttributeValue("", 906, Model.Firma, 906, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(919, 295, true);
                WriteLiteral(@" />


        <div class=""row"">
            <div class=""col-6"">
                <div class=""bg-primary text-white p-2 mt-3"">
                    Müşteri Bilgileri
                </div>
                <div class=""form-group"">
                    <label>Ad</label>
                    ");
                EndContext();
                BeginContext(1214, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d9919170b84cc5931d352f0405c7a1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 29 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Ad);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1257, 130, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Soyad</label>\r\n                    ");
                EndContext();
                BeginContext(1387, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0696b2b7c5d472e9e81af361dab075b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 33 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Soyad);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1433, 130, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>TC NO</label>\r\n                    ");
                EndContext();
                BeginContext(1563, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1842267efb514abb8ab8ad259e86f389", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 37 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TCKimlik);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1612, 131, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>E-Mail</label>\r\n                    ");
                EndContext();
                BeginContext(1743, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "310b8207c0e247ceb4104c91dc2ceb65", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 41 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1789, 113, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Cinsiyet</label>\r\n");
                EndContext();
                BeginContext(1977, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1998, 234, false);
#line 46 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
               Write(Html.DropDownList("Cinsiyet", new List<SelectListItem>{
       new SelectListItem{ Text="Bay", Value="Bay"},
       new SelectListItem{ Text="Bayan", Value="Bayan"}
       }, "--- Seçiniz ---", new {@class="form-control"}
       ));

#line default
#line hidden
                EndContext();
                BeginContext(2232, 137, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Doğum Tarihi</label>\r\n                    ");
                EndContext();
                BeginContext(2369, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd236184f9914a27960e4ab771ed9505", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 54 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DTarih);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2416, 130, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Adres</label>\r\n                    ");
                EndContext();
                BeginContext(2546, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de9cf4c380af439a91b096f4f35e8b2b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 58 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Adres);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2592, 158, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label>Firma</label>\r\n                    <br />\r\n                    ");
                EndContext();
                BeginContext(2751, 141, false);
#line 63 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
               Write(Html.DropDownListFor(x => x.FirmaId, new SelectList(ViewBag.Firmalar, "Id", "FirmaAdi"), "Firma Seçiniz...", new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(2892, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(2969, 137, true);
                WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\Section 3\Desktop\MixCRM\MixCRM\Views\Musteri\Edit.cshtml"
           WriteLiteral(ViewBag.ActionMode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3113, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Musteri> Html { get; private set; }
    }
}
#pragma warning restore 1591
