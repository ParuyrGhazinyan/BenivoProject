#pragma checksum "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\Job\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c09d5cbe05d04483fbb3e99aeba62cfcd333d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_Details), @"mvc.1.0.view", @"/Views/Job/Details.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\_ViewImports.cshtml"
using BenivoProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\_ViewImports.cshtml"
using BenivoProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\_ViewImports.cshtml"
using BenivoProject.Domain.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c09d5cbe05d04483fbb3e99aeba62cfcd333d3b", @"/Views/Job/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb2e0b996aa98b742e4d8e15ef914aa1a9d2ff8", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\Job\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-wrapper\">\r\n    <section class=\"content-header\" style=\" margin: 0 auto;max-width:1500px\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"row mb-2\">\r\n                <div class=\"col-sm-6\">\r\n                    <h1>");
#nullable restore
#line 10 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\Job\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
                <div class=""col-sm-6"">
                    <ol class=""breadcrumb float-sm-right"">
                        <li class=""breadcrumb-item""><a href=""/Job/Index"">Jobs</a></li>
                        <li class=""breadcrumb-item active"">Detail</li>
                    </ol>
                </div>
            </div>
        </div>
    </section>
    <section class=""content"" style="" margin: 0 auto;max-width:1500px"">
        <div class=""card"">
            <div class=""card-header"">
                <h3 class=""card-title"">Company """);
#nullable restore
#line 24 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\Job\Details.cshtml"
                                           Write(Model.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" </h3>
                <div class=""card-tools"">
                    <button type=""button"" class=""btn btn-tool"" data-card-widget=""collapse"" title=""Collapse"">
                        <i class=""fas fa-minus""></i>
                    </button>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-12 col-md-12 col-lg-8 order-2 order-md-1"">
                        <div class=""row"">
                            <div class=""col-12 col-sm-4"">
                                <div class=""info-box bg-light"">
                                    <div class=""info-box-content"">
                                        <span class=""info-box-text text-center text-muted"">Estimated budget</span>
                                        <span class=""info-box-number text-center text-muted mb-0"">2300</span>
                                    </div>
                                </div>
                            </div>
");
            WriteLiteral(@"                            <div class=""col-12 col-sm-4"">
                                <div class=""info-box bg-light"">
                                    <div class=""info-box-content"">
                                        <span class=""info-box-text text-center text-muted"">Total amount spent</span>
                                        <span class=""info-box-number text-center text-muted mb-0"">2000</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-12 col-sm-4"">
                                <div class=""info-box bg-light"">
                                    <div class=""info-box-content"">
                                        <span class=""info-box-text text-center text-muted"">Estimated project duration</span>
                                        <span class=""info-box-number text-center text-muted mb-0"">20</span>
                                    </div>
            ");
            WriteLiteral(@"                    </div>
                            </div>
                        </div>
                        <div class=""row"">
                            <div class=""col-12"">
                                <div class=""post"">
                                    <div class=""user-block"">
                                        <span class=""username"">
                                            <a href=""#"">Jonathan Burke Jr.</a>
                                        </span>
                                        <span class=""description"">Shared publicly - 7:45 PM today</span>
                                    </div>
                                    <p>
                                        ");
#nullable restore
#line 70 "C:\Users\USER\source\repos\BenivoProject\src\BenivoProject\Views\Job\Details.cshtml"
                                   Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </p>
                                </div>

                            </div>
                        </div>
                    </div>
                    <div class=""col-12 col-md-12 col-lg-4 order-1 order-md-2"">
                        <h3 class=""text-primary""><i class=""fas fa-paint-brush""></i> Some data about company</h3>
                        <p class=""text-muted"">Raw denim you probably haven't heard of them jean shorts Austin. Nesciunt tofu stumptown aliqua butcher retro keffiyeh dreamcatcher synth. Cosby sweater eu banh mi, qui irure terr.</p>
                        <br>
                        <div class=""text-muted"">
                            <p class=""text-sm"">
                                Client Company
                                <b class=""d-block"">Deveint Inc</b>
                            </p>
                            <p class=""text-sm"">
                                Project Leader
                                <b class");
            WriteLiteral(@"=""d-block"">Tony Chicken</b>
                            </p>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>
    <section class=""content-header"" style="" margin: 0 auto;max-width:1500px"">
        <div class=""container-fluid"">
            <div class=""mb-2"">               
                <div class="" float-right"">
                    <a href=""/job/index"" class=""btn btn-outline-secondary""><i class=""fa fa-angle-left mr-2""></i>Jobs list</a>
                </div>
            </div>
        </div>
    </section>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
