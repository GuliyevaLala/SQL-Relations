#pragma checksum "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf59b02b9e96fc1f37dd1c200737517f62e62aa7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
using SQL_Task;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
using SQL_Task.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf59b02b9e96fc1f37dd1c200737517f62e62aa7", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Group>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container d-flex justify-content-center\">\r\n");
#nullable restore
#line 6 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
     foreach (Group group in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
         foreach (Pupil student in group.Pupils)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card p-3 py-4\">\r\n                <div class=\"text-center\">\r\n                    <h3 class=\"mt-2\">Fulname: ");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
                                         Write(student.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
                                                       Write(student.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <div class=\"row mt-3 mb-3\">\r\n                        <div class=\"col-md-4\">\r\n                            <h5>Age</h5> <span class=\"inf\">");
#nullable restore
#line 15 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
                                                      Write(student.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"col-md-4\">\r\n                            <h5>Email</h5> <span class=\"inf\">");
#nullable restore
#line 18 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
                                                        Write(student.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 23 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Admin\Desktop\SQL-Task\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Group>> Html { get; private set; }
    }
}
#pragma warning restore 1591
