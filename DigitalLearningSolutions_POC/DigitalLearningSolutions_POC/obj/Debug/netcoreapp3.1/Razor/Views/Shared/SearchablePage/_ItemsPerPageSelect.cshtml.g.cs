#pragma checksum "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b77feec8a75060500c0e43ab30a0c7e0b6fdc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SearchablePage__ItemsPerPageSelect), @"mvc.1.0.view", @"/Views/Shared/SearchablePage/_ItemsPerPageSelect.cshtml")]
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
#line 1 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\_ViewImports.cshtml"
using DigitalLearningSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\_ViewImports.cshtml"
using DigitalLearningSolutions.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
using DLSPaginationSearchSort.ViewModels.Common.SearchablePage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b77feec8a75060500c0e43ab30a0c7e0b6fdc3", @"/Views/Shared/SearchablePage/_ItemsPerPageSelect.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"735f00b41d9682da5e0dd49273d5f56d23d1181f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_SearchablePage__ItemsPerPageSelect : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IBaseSearchablePageViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nhsuk-select items-per-page-dropdown nhsuk-u-margin-bottom-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("items-per-page-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-label", new global::Microsoft.AspNetCore.Html.HtmlString("Items per page"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nhsuk-button items-per-page-submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-page", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b77feec8a75060500c0e43ab30a0c7e0b6fdc36858", async() => {
                WriteLiteral("\r\n  <input type=\"hidden\" name=\"searchString\"");
                BeginWriteAttribute("value", " value=\"", 181, "\"", 208, 1);
#nullable restore
#line 5 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 189, Model.SearchString, 189, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n  <input type=\"hidden\" name=\"sortBy\"");
                BeginWriteAttribute("value", " value=\"", 250, "\"", 271, 1);
#nullable restore
#line 6 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 258, Model.SortBy, 258, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n  <input type=\"hidden\" name=\"sortDirection\"");
                BeginWriteAttribute("value", " value=\"", 320, "\"", 348, 1);
#nullable restore
#line 7 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 328, Model.SortDirection, 328, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 8 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
   if (Model.FilterEnabled) {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"hidden\" name=\"existingFilterString\"");
                BeginWriteAttribute("value", " value=\"", 437, "\"", 472, 1);
#nullable restore
#line 9 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 445, Model.ExistingFilterString, 445, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 10 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
  }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
   foreach (var (key, value) in Model.RouteData) {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 559, "\"", 570, 1);
#nullable restore
#line 12 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 566, key, 566, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 571, "\"", 585, 1);
#nullable restore
#line 12 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
WriteAttributeValue("", 579, value, 579, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 13 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
  }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
  <div class=""nhsuk-form-group items-per-page-select-container"">
    <label class=""nhsuk-label--s nhsuk-u-margin-bottom-1"" id=""items-per-page"" for=""items-per-page-select"">
      Items per page
    </label>
    <div class=""nhsuk-u-width-full items-per-page-button-container"">
      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b77feec8a75060500c0e43ab30a0c7e0b6fdc311248", async() => {
                    WriteLiteral("\r\n      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 22 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ItemsPerPage);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 23 "C:\Development\Test\DigitalLearningSolutions_POC\DigitalLearningSolutions_POC\Views\Shared\SearchablePage\_ItemsPerPageSelect.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.ItemsPerPageSelectListItems;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n      ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b77feec8a75060500c0e43ab30a0c7e0b6fdc313659", async() => {
                    WriteLiteral("\r\n        Update\r\n      ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["page"] = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IBaseSearchablePageViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
