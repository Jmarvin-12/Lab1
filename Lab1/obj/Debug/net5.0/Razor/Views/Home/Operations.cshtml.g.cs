#pragma checksum "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c48beb1aea984e137d59372f72b19635f9a3e0b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Operations), @"mvc.1.0.view", @"/Views/Home/Operations.cshtml")]
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
#line 1 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\_ViewImports.cshtml"
using Lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c48beb1aea984e137d59372f72b19635f9a3e0b5", @"/Views/Home/Operations.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59419ef1b1476a13ca8a84f44f57646c39f2efca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Operations : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Operations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
  

    var opeList = ViewBag.operationsList;

    string[] ops = {"SUMA: ", "RESTA: ", "MULTIPLICACION", "DIVISION", "POTENCIA: ", "RAIZ: "};
    


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""width:60%"" class=""container text-center contain"">
    <header>
        <h2 class=""titulito"">Operaciones matem??ticas</h2>
    </header>
</div>
<br />

<div id=""Division"" class=""container text-center contain"" style=""display:block"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c48beb1aea984e137d59372f72b19635f9a3e0b54348", async() => {
                WriteLiteral(@"
        <br />
        <div class=""row"">
            <div class=""col""></div>
            <div class=""col"">
                <h5>Ingrese el primer numero</h5>
                <input class=""form-control "" type=""text"" name=""num1"" />
            </div>
            <div class=""col""></div>
        </div>
        <div class=""row"">
            <div class=""col""></div>
            <div class=""col"">
                <h5>Ingrese el segundo numero</h5>
                <input class=""form-control "" type=""text"" name=""num2"" />
            </div>
            <div class=""col""></div>
        </div><br />
        <div class=""row"">
            <div class=""col""></div>
            <div class=""col"">
                <h5>Ingrese potencia a la que desea elevar</h5>
                <input class=""form-control "" type=""text"" name=""num3"" />
            </div>
            <div class=""col""></div>
        </div><br />
        <div class=""row"">
            <div class=""col""></div>
            <div class=""col"">
        ");
                WriteLiteral("        <input class=\"form-control \" type=\"submit\" value=\"Calcular\" />\r\n            </div>\r\n            <div class=\"col\"></div>\r\n        </div>\r\n    ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <br />\r\n\r\n</div>\r\n<br /><br />\r\n\r\n      <div class=\"contain container text-center\">\r\n\r\n");
#nullable restore
#line 62 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
           if (ViewBag.operationsList != null)
          {
              var count = 0;
              foreach (var d in opeList)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <div class=\"row \">\r\n                      <div class=\"col-3\"></div>\r\n                      <div class=\"col-3\"><h6>");
#nullable restore
#line 69 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
                                        Write(ops[count]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6></div>\r\n                      <div class=\"col-3\">\r\n                          <h6>");
#nullable restore
#line 71 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
                         Write(d);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                      </div>\r\n                      <div class=\"col-3\"></div>\r\n                  </div>\r\n");
#nullable restore
#line 75 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
                  count++;
              }
             
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("              <div>\r\n                  <h6>\r\n                      ");
#nullable restore
#line 81 "C:\Users\PEDEPE\source\repos\Lab1\Lab1\Views\Home\Operations.cshtml"
                 Write(ViewBag.OpError);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                  </h6>\r\n              </div>\r\n\r\n          </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
