#pragma checksum "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b5f11ffae8382779e836a935d53838288d753ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\_ViewImports.cshtml"
using OceanProducts.Web;

#line default
#line hidden
#line 2 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\_ViewImports.cshtml"
using OceanProducts.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b5f11ffae8382779e836a935d53838288d753ab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e6e3f71573327e256c1fb0f47f9d285b76bf210", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OceanProducts.Web.Models.Home.HomeIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-3 control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 501, true);
            WriteLiteral(@"    <script>
        function CategoryChange(val) {
            if (val > 0) {
                window.location.href = ""/Index/"" + val;
            }
            else {
                window.location.href = ""/"";
            }
        
    }
    </script>
<div class=""container body-content"">
    <div class=""row frontPageSplash"">
        <div class=""col-md-6 frontPageLearn"">

            <p class=""frontPageSubHeading"">This is online shopping site for Product</p>
            <div>
                ");
            EndContext();
            BeginContext(553, 623, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5f11ffae8382779e836a935d53838288d753ab7654", async() => {
                BeginContext(615, 70, true);
                WriteLiteral("\n                    <div class=\"form-group\">\n                        ");
                EndContext();
                BeginContext(685, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5f11ffae8382779e836a935d53838288d753ab8106", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 21 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(752, 76, true);
                WriteLiteral("\n                        <div class=\"col-md-6\">\n                            ");
                EndContext();
                BeginContext(829, 171, false);
#line 23 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                       Write(Html.DropDownListFor(model => model.CategoryId, (SelectList)ViewBag.Categories,
                           " -- All -- ", new { @onchange = "CategoryChange(this.value)" }));

#line default
#line hidden
                EndContext();
                BeginContext(1000, 29, true);
                WriteLiteral("\n                            ");
                EndContext();
                BeginContext(1029, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5f11ffae8382779e836a935d53838288d753ab10451", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 25 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CategoryId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1094, 75, true);
                WriteLiteral("\n                        </div>\n                    </div>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1176, 83, true);
            WriteLiteral("\n            </div>\n        </div>\n        <div class=\"col-md-6\"></div>\n    </div>\n");
            EndContext();
#line 33 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
     if (Model.ProductsList.Any())
    {

#line default
#line hidden
            BeginContext(1299, 965, true);
            WriteLiteral(@"<table class=""table table-hover"" id=""latestProductsTable"">
         <thead class=""font-weight-bold"">
             <tr>
                 <td>

                    Id

                 </td>
                 <td>
                     Product Code
                 </td>
                 <td>
                     Product Name
                 </td>
                 <td>
                    Description
                 </td>
                 <td>
                    Mfg. Date
                 </td>
                 <td>
                     Price
                 </td>
                 <td>
                    Activate
                 </td>

                 <td>
                     Created Date
                 </td>
                 <td>
                    Updated Date
                 </td>
                 <td colspan=""2"">
                     
                   Action
                 </td>
             </tr>
         </thead>
            <tbody>
");
            EndContext();
#line 74 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                 foreach (var product in Model.ProductsList)
                {

#line default
#line hidden
            BeginContext(2343, 23, true);
            WriteLiteral("<tr>\n    <td>\n\n        ");
            EndContext();
            BeginContext(2367, 10, false);
#line 79 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2377, 29, true);
            WriteLiteral("\n\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2407, 19, false);
#line 83 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.ProductCode);

#line default
#line hidden
            EndContext();
            BeginContext(2426, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2455, 12, false);
#line 86 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2467, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2496, 19, false);
#line 89 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2515, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2544, 15, false);
#line 92 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.MfgDate);

#line default
#line hidden
            EndContext();
            BeginContext(2559, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2588, 17, false);
#line 95 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2605, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2634, 16, false);
#line 98 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(2650, 29, true);
            WriteLiteral("\n    </td>\n\n    <td>\n        ");
            EndContext();
            BeginContext(2680, 16, false);
#line 102 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.CreateTs);

#line default
#line hidden
            EndContext();
            BeginContext(2696, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2725, 16, false);
#line 105 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
   Write(product.UpdateTs);

#line default
#line hidden
            EndContext();
            BeginContext(2741, 28, true);
            WriteLiteral("\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2769, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5f11ffae8382779e836a935d53838288d753ab18941", async() => {
                BeginContext(2863, 26, true);
                WriteLiteral("\n            Edit\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                                                                             WriteLiteral(product.Id);

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
            BeginContext(2893, 29, true);
            WriteLiteral("\n\n    </td>\n    <td>\n        ");
            EndContext();
            BeginContext(2922, 170, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b5f11ffae8382779e836a935d53838288d753ab21665", async() => {
                BeginContext(3060, 28, true);
                WriteLiteral("\n            Delete\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                                                                                                                         WriteLiteral(product.Id);

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
            BeginContext(3092, 17, true);
            WriteLiteral("\n    </td>\n</tr>\n");
            EndContext();
#line 119 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3111, 38, true);
            WriteLiteral("            </tbody>\n        </table> ");
            EndContext();
#line 121 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                 }
    else
    {

#line default
#line hidden
            BeginContext(3166, 53, true);
            WriteLiteral("<h4>It looks like there are no search results...</h4>");
            EndContext();
#line 124 "D:\subhash\Projects\OceanProducts\OceanProducts\OceanProducts.Web\Views\Home\Index.cshtml"
                                                     }

#line default
#line hidden
            BeginContext(3221, 7, true);
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OceanProducts.Web.Models.Home.HomeIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
