#pragma checksum "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\Account\Lockout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d07c45db63ebc1ae72a67d80919475a6c58f85d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Lockout), @"mvc.1.0.view", @"/Views/Account/Lockout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Lockout.cshtml", typeof(AspNetCore.Views_Account_Lockout))]
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
#line 1 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums;

#line default
#line hidden
#line 3 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums.Models;

#line default
#line hidden
#line 4 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums.Models.ManageViewModels;

#line default
#line hidden
#line 6 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\_ViewImports.cshtml"
using LambdaForums.Models.Forum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d07c45db63ebc1ae72a67d80919475a6c58f85d", @"/Views/Account/Lockout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f64b7de650e2c9465e65599f4fd83baa8f6fa89", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Lockout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\Account\Lockout.cshtml"
  
    ViewData["Title"] = "Locked out";

#line default
#line hidden
            BeginContext(46, 40, true);
            WriteLiteral("\r\n<header>\r\n    <h2 class=\"text-danger\">");
            EndContext();
            BeginContext(87, 17, false);
#line 6 "C:\Users\MNepal.LIBERTY\Source\Repos\LambdaForums\LambdaForums\LambdaForums\Views\Account\Lockout.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(104, 108, true);
            WriteLiteral("</h2>\r\n    <p class=\"text-danger\">This account has been locked out, please try again later.</p>\r\n</header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
