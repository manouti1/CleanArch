#pragma checksum "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c09f861998726f02c2f0f68f39852e60523b5f3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
#line 1 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\_ViewImports.cshtml"
using CleanArch.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c09f861998726f02c2f0f68f39852e60523b5f3a", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"184ad7c5537e27b2cab4d0f929bb76a5fd8a03dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CleanArch.Application.ViewModels.CourseViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container body-content\">\r\n    <div class=\"row course-content\">\r\n");
#nullable restore
#line 5 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\Course\Index.cshtml"
         foreach (var course in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"course-img-container\">\r\n                <div class=\"course-img\"");
            BeginWriteAttribute("style", " style=\"", 286, "\"", 332, 3);
            WriteAttributeValue("", 294, "background-image:url(", 294, 21, true);
#nullable restore
#line 8 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\Course\Index.cshtml"
WriteAttributeValue("", 315, course.ImageUrl, 315, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 331, ")", 331, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n            </div>\r\n");
            WriteLiteral("            <span>");
#nullable restore
#line 11 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\Course\Index.cshtml"
             Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 12 "C:\Users\Mohamad\Desktop\CleanArchitecture\CleanArch.Mvc\Views\Course\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CleanArch.Application.ViewModels.CourseViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
