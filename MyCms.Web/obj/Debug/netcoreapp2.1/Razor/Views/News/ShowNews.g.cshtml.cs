#pragma checksum "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c59a6e3923f6f745abfe28ee7b9cfab62cc63078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_ShowNews), @"mvc.1.0.view", @"/Views/News/ShowNews.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/ShowNews.cshtml", typeof(AspNetCore.Views_News_ShowNews))]
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
#line 1 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
using MyCms.Utilities.Convertor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c59a6e3923f6f745abfe28ee7b9cfab62cc63078", @"/Views/News/ShowNews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Views/_ViewImports.cshtml")]
    public class Views_News_ShowNews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyCms.DomainClasses.Page.Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
  
    ViewData["Title"] = Model.PageTitle;

#line default
#line hidden
            BeginContext(121, 64, true);
            WriteLiteral("\r\n<section class=\"single-news border-radius\">\r\n    <header><h2> ");
            EndContext();
            BeginContext(186, 15, false);
#line 8 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
            Write(Model.PageTitle);

#line default
#line hidden
            EndContext();
            BeginContext(201, 55, true);
            WriteLiteral(" </h2> <span> <i class=\"fa fa-calendar\"></i>  انتشار : ");
            EndContext();
            BeginContext(257, 27, false);
#line 8 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
                                                                                   Write(Model.CreateDate.ToShamsi());

#line default
#line hidden
            EndContext();
            BeginContext(284, 58, true);
            WriteLiteral("</span></header>\r\n    <article>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(343, 22, false);
#line 11 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
       Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(365, 26, true);
            WriteLiteral("\r\n        </p>\r\n        \r\n");
            EndContext();
#line 14 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
         if (Model.ImageName != null)
        {

#line default
#line hidden
            BeginContext(441, 39, true);
            WriteLiteral("            <div>\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 480, "\"", 514, 2);
            WriteAttributeValue("", 486, "/PageImages/", 486, 12, true);
#line 17 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 498, Model.ImageName, 498, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 515, "\"", 537, 1);
#line 17 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 521, Model.PageTitle, 521, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(538, 42, true);
            WriteLiteral(" class=\"thumbnail\"/>\r\n            </div>\r\n");
            EndContext();
#line 19 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
        }

#line default
#line hidden
            BeginContext(591, 27, true);
            WriteLiteral("\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(619, 14, false);
#line 22 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
       Write(Model.PageText);

#line default
#line hidden
            EndContext();
            BeginContext(633, 82, true);
            WriteLiteral("\r\n        </p>\r\n    </article>\r\n</section>\r\n<div class=\"keywords border-radius\">\r\n");
            EndContext();
#line 27 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
     foreach (var item in Model.PageTags.Split('-'))
    {

#line default
#line hidden
            BeginContext(776, 10, true);
            WriteLiteral("        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 786, "\"", 808, 2);
            WriteAttributeValue("", 793, "/Search?q=", 793, 10, true);
#line 29 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
WriteAttributeValue("", 803, item, 803, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(809, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(812, 4, false);
#line 29 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
                              Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(816, 7, true);
            WriteLiteral(" </a>\r\n");
            EndContext();
#line 30 "F:\Asp.NetCore\21_Asp.NetCore_CMS_ShowNews\MyCms\MyCms.Web\Views\News\ShowNews.cshtml"
    }

#line default
#line hidden
            BeginContext(830, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyCms.DomainClasses.Page.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
