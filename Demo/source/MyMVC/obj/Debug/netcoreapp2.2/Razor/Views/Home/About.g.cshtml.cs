#pragma checksum "C:\Users\carbo\Luis Sergio\Demo\source\MyMVC\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f476bed5357e9bebc0fc6f722addc408fd0db095"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "C:\Users\carbo\Luis Sergio\Demo\source\MyMVC\Views\_ViewImports.cshtml"
using MyMVC;

#line default
#line hidden
#line 2 "C:\Users\carbo\Luis Sergio\Demo\source\MyMVC\Views\_ViewImports.cshtml"
using MyMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f476bed5357e9bebc0fc6f722addc408fd0db095", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55cb7347c22ceb68b4bfa71a252ac30b640ee9a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\carbo\Luis Sergio\Demo\source\MyMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(44, 758, true);
            WriteLiteral(@"
<div style=""margin-top:5%"">
<h5>This page was created to encourage the use of ASP.NET and Docker</h5>
</div>

<div style=""margin-top:5%"">
<h2>What is docker?</h2>
<p>Docker is an open-source project that automates the development, deployment and running of applications inside isolated containers. 
Containers allow developers to bundle up an application with all of the parts it needs, such as libraries and other dependencies, 
and ship it as one package.</p>
</div>

<div style=""margin-top:5%"">
<h2>What about ASP.NET?</h2>
<p>ASP.NET is an open source web framework, created by Microsoft, for building modern web apps and services with .NET.
ASP.NET is cross platform and runs on Windows, Linux, macOS, and Docker.</p>
</div>





");
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
