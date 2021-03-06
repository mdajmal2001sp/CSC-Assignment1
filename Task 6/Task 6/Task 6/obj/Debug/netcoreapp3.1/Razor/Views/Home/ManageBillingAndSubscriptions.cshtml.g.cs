#pragma checksum "C:\CSC_ca1\Task 6\Task 6\Views\Home\ManageBillingAndSubscriptions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7af3c63bab96f364e6d6d033a047dd8f50c1830c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ManageBillingAndSubscriptions), @"mvc.1.0.view", @"/Views/Home/ManageBillingAndSubscriptions.cshtml")]
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
#line 1 "C:\CSC_ca1\Task 6\Task 6\Views\_ViewImports.cshtml"
using Task_6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\CSC_ca1\Task 6\Task 6\Views\_ViewImports.cshtml"
using Task_6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7af3c63bab96f364e6d6d033a047dd8f50c1830c", @"/Views/Home/ManageBillingAndSubscriptions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1d94cd443fb7673efc48ec613cf9e9e94691ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ManageBillingAndSubscriptions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\CSC_ca1\Task 6\Task 6\Views\Home\ManageBillingAndSubscriptions.cshtml"
  
    ViewData["Title"] = "Redirect to Customer Portal";

#line default
#line hidden
#nullable disable
            DefineSection("scripts", async() => {
                WriteLiteral(@"
<script>
    function getPortalSession() {
        $.ajax({
            url: '/api/managebilling/createsession',
            type: 'post',
            success: function (data) {
                $('#status').hide();
                $('#redirectStatement').show();
                setTimeout(function () {
                    window.location.replace(data.url);
                }, 3000);
            },
            error: function (result) {
                $('#status').html('<img src=""/ajax-loader.gif"" /> Failed to create customer portal session, retrying...');
                setTimeout(getPortalSession, 3000);
            }
        });
    }
    $('document').ready(function () {
        $('#status').html('<img src=""/ajax-loader.gif"" /> Creating customer portal session...');
        getPortalSession();
    }); 
    
    
</script>
");
            }
            );
            WriteLiteral("\n<style>\n    #redirectStatement {\n        display:none\n    }\n</style>\n<h1>Manage billing and subscriptions</h1>\n<div id=\"status\"></div>\n<p id=\"redirectStatement\">You will be redirected to the Stripe self-serve customer portal shortly.</p>\n\n");
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
