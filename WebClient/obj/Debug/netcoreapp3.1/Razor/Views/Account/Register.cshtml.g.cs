#pragma checksum "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c79502f15030b5d09b92ecebea2c3a288120b47b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
#line 1 "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79502f15030b5d09b92ecebea2c3a288120b47b", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\Account\Register.cshtml"
  
    ViewData["Title"] = "Register Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!--start-breadcrumbs-->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""breadcrumbs-main"">
            <ol class=""breadcrumb"">
                <li><a href=""index.html"">Home</a></li>
                <li class=""active"">Register</li>
            </ol>
        </div>
    </div>
</div>
<!--end-breadcrumbs-->
<!--register-starts-->
<div class=""register"">
    <div class=""container"">
        <div class=""register-top heading"">
            <h2>REGISTER</h2>
        </div>
        <div class=""register-main"">
            <div class=""col-md-6 account-left"">
                <input placeholder=""First name"" type=""text"" tabindex=""1"" required>
                <input placeholder=""Last name"" type=""text"" tabindex=""2"" required>
                <input placeholder=""Email address"" type=""text"" tabindex=""3"" required>
                <input placeholder=""Mobile"" type=""text"" tabindex=""3"" required>
                <ul>
                    <li><label class=""radio left""><input type=""radio");
            WriteLiteral("\" name=\"radio\"");
            BeginWriteAttribute("checked", " checked=\"", 1087, "\"", 1097, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i></i>Male</label></li>
                    <li><label class=""radio""><input type=""radio"" name=""radio""><i></i>Female</label></li>
                    <div class=""clearfix""></div>
                </ul>
            </div>
            <div class=""col-md-6 account-left"">
                <input placeholder=""Password"" type=""password"" tabindex=""4"" required>
                <input placeholder=""Retype password"" type=""password"" tabindex=""4"" required>
            </div>
            <div class=""clearfix""></div>
        </div>
        <div class=""address submit"">
            <input type=""submit"" value=""Submit"">
        </div>
    </div>
</div>
<!--register-end-->");
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
