#pragma checksum "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cd6d1c1756f01d01891b5d9039ecf67b150289a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPagesMovie.Pages.Pages_Review), @"mvc.1.0.razor-page", @"/Pages/Review.cshtml")]
namespace RazorPagesMovie.Pages
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
#line 1 "P:\ASPNET\RazorPagesMovie\Pages\_ViewImports.cshtml"
using RazorPagesMovie;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cd6d1c1756f01d01891b5d9039ecf67b150289a", @"/Pages/Review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bffd98f02597e6a09295a2131188dc64093be78", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Review : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<html>
<div class=""container"">
    <div class=""row"">
        <div class=""col-sm-6"">
            <img class=""img-thumbnail"" src=""https://usustatesman.com/wp-content/uploads/2016/12/movie-reviews-design.jpg?w=640"" />
        </div>

        <div class=""col-sm-6"">
            <h1>Movie Reviews</h1>
            <p>This is a site of very, very lengthy movie reviews.  It will go on and on. Because it is a review site, there will be very little positive said.</p>

        </div>
    </div>

");
#nullable restore
#line 20 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
     foreach (var item in Model.Review)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-sm-6\">\r\n                <h1>");
#nullable restore
#line 26 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
               Write(Html.DisplayFor(modelItem => item.MovieName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 28 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
                 for (var i = 0; i < item.NumberOfStars; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img width=\"40\" src=\"https://www.pngfind.com/pngs/m/61-610882_gold-star-png-download-gold-star-transparent-png.png\" />\r\n");
#nullable restore
#line 31 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>");
#nullable restore
#line 32 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
          Write(Html.DisplayFor(modelItem => item.ReviewText));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n\r\n            <div class=\"col-sm-6\">\r\n                <img class=\"img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 1173, "\"", 1223, 1);
#nullable restore
#line 36 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
WriteAttributeValue("", 1179, Html.DisplayFor(modelItem => item.ImageURL), 1179, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "P:\ASPNET\RazorPagesMovie\Pages\Review.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RazorPagesMovie.Pages.ReviewsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.ReviewsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RazorPagesMovie.Pages.ReviewsModel>)PageContext?.ViewData;
        public RazorPagesMovie.Pages.ReviewsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
