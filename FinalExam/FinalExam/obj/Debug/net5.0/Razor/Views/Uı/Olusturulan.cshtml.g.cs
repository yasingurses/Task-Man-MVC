#pragma checksum "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0868a40cdc2338e3af4463a490018a623f3a7a82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uı_Olusturulan), @"mvc.1.0.view", @"/Views/Uı/Olusturulan.cshtml")]
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
#line 1 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\_ViewImports.cshtml"
using FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\_ViewImports.cshtml"
using FinalExam.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
using EntityLayer.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0868a40cdc2338e3af4463a490018a623f3a7a82", @"/Views/Uı/Olusturulan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b258923ea310fabbc88b297271c18efd705121e9", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Uı_Olusturulan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Gorevler>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Uı", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ekle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary rounded-pill"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Yorumlar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
  
    ViewData["Title"] = "Olusturulan";
    Layout = "~/Views/Shared/_UıLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .gradient-custom-2 {
        /* fallback for old browsers */
        background: #7e40f6;
        /* Chrome 10-25, Safari 5.1-6 */
        background: -webkit-linear-gradient( to right, rgba(126, 64, 246, 1), rgba(80, 139, 252, 1) );
        /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
        background: linear-gradient( to right, rgba(126, 64, 246, 1), rgba(80, 139, 252, 1) );
    }

    .mask-custom {
        background: rgba(24, 24, 16, 0.2);
        border-radius: 2em;
        backdrop-filter: blur(25px);
        border: 2px solid rgba(255, 255, 255, 0.05);
        background-clip: padding-box;
        box-shadow: 10px 10px 10px rgba(46, 54, 68, 0.03);
    }</style>
<section class=""vh-100 gradient-custom-2"">
    <div class=""container py-5 h-100"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col-md-12 col-xl-10"">

                <div class=""card mask-custom"">
                    <di");
            WriteLiteral(@"v class=""card-body p-4 text-white"">

                        <div class=""text-center pt-3 pb-2"">
                            <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-todo-list/check1.webp""
                                 alt=""Check"" width=""60"">
                            <h2 class=""my-4"">Görev Listesi</h2>
                        </div>

                        <table class=""table text-white mb-0"">
                            <thead>
                                <tr>
                                    <th scope=""col"">Görev Sahibi</th>
                                    <th scope=""col"">Görev Başlığı</th>
                                    <th scope=""col"">Görev Acıklaması</th>
                                    <th scope=""col"">Görev Durumu</th>
                                    <th scope=""col"">Tarih</th>
                                    <th scope=""col"">Yorum</th>


                                </tr>
                            </thead>
         ");
            WriteLiteral("                   <tbody>\r\n");
#nullable restore
#line 56 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                 foreach (var item in Model)
                                {
                                    if (item.GorevDurumu == Status.Oluştruldu.ToString())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr class=""fw-normal"">
                                            <th>
                                                <img src=""https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava6-bg.webp""
                                             alt=""avatar 1"" style=""width: 45px; height: auto;"">
                                                <span class=""ms-2"">");
#nullable restore
#line 64 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                              Write(item.GorevSahibi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </th>\r\n                                            <td class=\"align-middle\">\r\n                                                <span>");
#nullable restore
#line 67 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                 Write(item.GorevTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"align-middle\">\r\n                                                <span>");
#nullable restore
#line 70 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                 Write(item.GorevAciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"align-middle\">\r\n                                                <span>");
#nullable restore
#line 73 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                 Write(item.GorevDurumu);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"align-middle\">\r\n                                                <span>");
#nullable restore
#line 76 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                 Write(item.GorevTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td class=\"align-middle\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0868a40cdc2338e3af4463a490018a623f3a7a8210705", async() => {
                WriteLiteral("Yorum Yap");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gorevId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                                                                                                  WriteLiteral(item.GorevID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gorevId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gorevId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gorevId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0868a40cdc2338e3af4463a490018a623f3a7a8213307", async() => {
                WriteLiteral("Yorumları görüntüle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-gorevId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"
                                                                                                                                         WriteLiteral(item.GorevID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gorevId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-gorevId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["gorevId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 83 "C:\Users\Yasin\Desktop\Exam\FinalExam\FinalExam\Views\Uı\Olusturulan.cshtml"

                                }
                                    
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Gorevler>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
