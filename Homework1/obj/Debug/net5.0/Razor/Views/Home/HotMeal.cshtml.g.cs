#pragma checksum "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "84933d5d88565ef78fdcb39d3cba92a8d47f536d72ae01c1ea9826b0ed61cc52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HotMeal), @"mvc.1.0.view", @"/Views/Home/HotMeal.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\_ViewImports.cshtml"
using Homework1

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\_ViewImports.cshtml"
using Homework1.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"84933d5d88565ef78fdcb39d3cba92a8d47f536d72ae01c1ea9826b0ed61cc52", @"/Views/Home/HotMeal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b5d03c00fbf18caefb88307bf9790394ad40dd3bbb940862997f6faa1ae5ed77", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_HotMeal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Homework1.Entities.HotMeal>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84933d5d88565ef78fdcb39d3cba92a8d47f536d72ae01c1ea9826b0ed61cc523673", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>HotMeal</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "84933d5d88565ef78fdcb39d3cba92a8d47f536d72ae01c1ea9826b0ed61cc524758", async() => {
                WriteLiteral("\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 20 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 23 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 26 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayNameFor(model => model.Description)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable

                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 35 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayFor(modelItem => item.Id)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayFor(modelItem => item.Name)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
                 Html.DisplayFor(modelItem => item.Description)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\Homework1\Homework1\Views\Home\HotMeal.cshtml"
}

#line default
#line hidden
#nullable disable

                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Homework1.Entities.HotMeal>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
