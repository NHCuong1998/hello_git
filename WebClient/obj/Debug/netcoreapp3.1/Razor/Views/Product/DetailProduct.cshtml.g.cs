#pragma checksum "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\Product\DetailProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fcbeebe1329cf9c60033b4a669b9a7f5fc11988"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_DetailProduct), @"mvc.1.0.view", @"/Views/Product/DetailProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fcbeebe1329cf9c60033b4a669b9a7f5fc11988", @"/Views/Product/DetailProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_DetailProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ngohu\source\repos\ASP.Net\WebClient\Views\Product\DetailProduct.cshtml"
  
    ViewData["Title"] = "Detail Product Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script>$(document).ready(function () { $("".memenu"").memenu(); });</script>
<!--dropdown-->
<script src=""js/jquery.easydropdown.js""></script>
<script type=""text/javascript"">
    $(function () {

        var menu_ul = $('.menu_drop > li > ul'),
            menu_a = $('.menu_drop > li > a');

        menu_ul.hide();

        menu_a.click(function (e) {
            e.preventDefault();
            if (!$(this).hasClass('active')) {
                menu_a.removeClass('active');
                menu_ul.filter(':visible').slideUp('normal');
                $(this).addClass('active').next().stop(true, true).slideDown('normal');
            } else {
                $(this).removeClass('active');
                $(this).next().stop(true, true).slideUp('normal');
            }
        });

    });
</script>


<!--start-breadcrumbs-->
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""breadcrumbs-main"">
            <ol class=""breadcrumb"">
                <li><a h");
            WriteLiteral(@"ref=""index.html"">Home</a></li>
                <li class=""active"">Single</li>
            </ol>
        </div>
    </div>
</div>
<!--end-breadcrumbs-->
<!--start-single-->
<div class=""single contact"">
    <div class=""container"">
        <div class=""single-main"">
            <div class=""col-md-9 single-main-left"">
                <div class=""sngl-top"">
                    <div class=""col-md-5 single-top-left"">
                        <div class=""flexslider"">
                            <ul class=""slides"">
                                <li data-thumb=""images/s-1.jpg"">
                                    <div class=""thumb-image""> <img src=""images/s-1.jpg"" data-imagezoom=""true"" class=""img-responsive""");
            BeginWriteAttribute("alt", " alt=\"", 1803, "\"", 1809, 0);
            EndWriteAttribute();
            WriteLiteral(" /> </div>\r\n                                </li>\r\n                                <li data-thumb=\"images/s-2.jpg\">\r\n                                    <div class=\"thumb-image\"> <img src=\"images/s-2.jpg\" data-imagezoom=\"true\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 2059, "\"", 2065, 0);
            EndWriteAttribute();
            WriteLiteral(" /> </div>\r\n                                </li>\r\n                                <li data-thumb=\"images/s-3.jpg\">\r\n                                    <div class=\"thumb-image\"> <img src=\"images/s-3.jpg\" data-imagezoom=\"true\" class=\"img-responsive\"");
            BeginWriteAttribute("alt", " alt=\"", 2315, "\"", 2321, 0);
            EndWriteAttribute();
            WriteLiteral(@" /> </div>
                                </li>
                            </ul>
                        </div>
                        <!-- FlexSlider -->
                        <script src=""js/imagezoom.js""></script>
                        <script defer src=""js/jquery.flexslider.js""></script>
                        <link rel=""stylesheet"" href=""css/flexslider.css"" type=""text/css"" media=""screen"" />

                        <script>
                            // Can also be used with $(document).ready()
                            $(window).load(function () {
                                $('.flexslider').flexslider({
                                    animation: ""slide"",
                                    controlNav: ""thumbnails""
                                });
                            });
                        </script>
                    </div>
                    <div class=""col-md-7 single-top-right"">
                        <div class=""single-para simpleCart_shelfI");
            WriteLiteral(@"tem"">
                            <h2>Lorem Ipsum</h2>
                            <div class=""star-on"">
                                <ul class=""star-footer"">
                                    <li><a href=""#""><i> </i></a></li>
                                    <li><a href=""#""><i> </i></a></li>
                                    <li><a href=""#""><i> </i></a></li>
                                    <li><a href=""#""><i> </i></a></li>
                                    <li><a href=""#""><i> </i></a></li>
                                </ul>
                                <div class=""review"">
                                    <a href=""#""> 1 customer review </a>

                                </div>
                                <div class=""clearfix""> </div>
                            </div>

                            <h5 class=""item_price"">$ 95.00</h5>
                            <p>Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ");
            WriteLiteral(@"ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</p>
                            <div class=""available"">
                                <ul>
                                    <li>
                                        Color
                                        <select>
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc119888679", async() => {
                WriteLiteral("Silver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc119889681", async() => {
                WriteLiteral("Black");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198810682", async() => {
                WriteLiteral("Dark Black");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198811689", async() => {
                WriteLiteral("Red");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </select>\r\n                                    </li>\r\n                                    <li class=\"size-in\">\r\n                                        Size<select>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198812905", async() => {
                WriteLiteral("Large");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198813907", async() => {
                WriteLiteral("Medium");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198814910", async() => {
                WriteLiteral("small");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198815912", async() => {
                WriteLiteral("Large");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6fcbeebe1329cf9c60033b4a669b9a7f5fc1198816914", async() => {
                WriteLiteral("small");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </select>
                                    </li>
                                    <div class=""clearfix""> </div>
                                </ul>
                            </div>
                            <ul class=""tag-men"">
                                <li>
                                    <span>TAG</span>
                                    <span class=""women1"">: Women,</span>
                                </li>
                                <li>
                                    <span>SKU</span>
                                    <span class=""women1"">: CK09</span>
                                </li>
                            </ul>
                            <a href=""#"" class=""add-cart item_add"">ADD TO CART</a>

                        </div>
                    </div>
                    <div class=""clearfix""> </div>
                </div>
                <div class=""tabs"">
                    <ul class=""menu_d");
            WriteLiteral("rop\">\r\n                        <li class=\"item1\">\r\n                            <a href=\"#\"><img src=\"images/arrow.png\"");
            BeginWriteAttribute("alt", " alt=\"", 6743, "\"", 6749, 0);
            EndWriteAttribute();
            WriteLiteral(@">Description</a>
                            <ul>
                                <li class=""subitem1""><a href=""#"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</a></li>
                                <li class=""subitem2""><a href=""#""> Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore</a></li>
                                <li class=""subitem3""><a href=""#"">Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes </a></li>
");
            WriteLiteral("                            </ul>\r\n                        </li>\r\n                        <li class=\"item2\">\r\n                            <a href=\"#\"><img src=\"images/arrow.png\"");
            BeginWriteAttribute("alt", " alt=\"", 7951, "\"", 7957, 0);
            EndWriteAttribute();
            WriteLiteral(@">Additional information</a>
                            <ul>
                                <li class=""subitem2""><a href=""#""> Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore</a></li>
                                <li class=""subitem3""><a href=""#"">Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes </a></li>
                            </ul>
                        </li>
                        <li class=""item3"">
                            <a href=""#""><img src=""images/arrow.png""");
            BeginWriteAttribute("alt", " alt=\"", 8822, "\"", 8828, 0);
            EndWriteAttribute();
            WriteLiteral(@">Reviews (10)</a>
                            <ul>
                                <li class=""subitem1""><a href=""#"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</a></li>
                                <li class=""subitem2""><a href=""#""> Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore</a></li>
                                <li class=""subitem3""><a href=""#"">Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes </a></li>");
            WriteLiteral("\n                            </ul>\r\n                        </li>\r\n                        <li class=\"item4\">\r\n                            <a href=\"#\"><img src=\"images/arrow.png\"");
            BeginWriteAttribute("alt", " alt=\"", 10031, "\"", 10037, 0);
            EndWriteAttribute();
            WriteLiteral(@">Helpful Links</a>
                            <ul>
                                <li class=""subitem2""><a href=""#""> Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore</a></li>
                                <li class=""subitem3""><a href=""#"">Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes </a></li>
                            </ul>
                        </li>
                        <li class=""item5"">
                            <a href=""#""><img src=""images/arrow.png""");
            BeginWriteAttribute("alt", " alt=\"", 10893, "\"", 10899, 0);
            EndWriteAttribute();
            WriteLiteral(@">Make A Gift</a>
                            <ul>
                                <li class=""subitem1""><a href=""#"">Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.</a></li>
                                <li class=""subitem2""><a href=""#""> Duis autem vel eum iriure dolor in hendrerit in vulputate velit esse molestie consequat, vel illum dolore eu feugiat nulla facilisis at vero eros et accumsan et iusto odio dignissim qui blandit praesent luptatum zzril delenit augue duis dolore</a></li>
                                <li class=""subitem3""><a href=""#"">Mirum est notare quam littera gothica, quam nunc putamus parum claram, anteposuerit litterarum formas humanitatis per seacula quarta decima et quinta decima. Eodem modo typi, qui nunc nobis videntur parum clari, fiant sollemnes </a></li>
");
            WriteLiteral(@"                            </ul>
                        </li>
                    </ul>
                </div>
                <div class=""latestproducts"">
                    <div class=""product-one"">
                        <div class=""col-md-4 product-left p-left"">
                            <div class=""product-main simpleCart_shelfItem"">
                                <a href=""single.html"" class=""mask""><img class=""img-responsive zoom-img"" src=""images/p-1.png""");
            BeginWriteAttribute("alt", " alt=\"", 12403, "\"", 12409, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                <div class=""product-bottom"">
                                    <h3>Smart Watches</h3>
                                    <p>Explore Now</p>
                                    <h4><a class=""item_add"" href=""#""><i></i></a> <span class="" item_price"">$ 329</span></h4>
                                </div>
                                <div class=""srch"">
                                    <span>-50%</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 product-left p-left"">
                            <div class=""product-main simpleCart_shelfItem"">
                                <a href=""single.html"" class=""mask""><img class=""img-responsive zoom-img"" src=""images/p-2.png""");
            BeginWriteAttribute("alt", " alt=\"", 13247, "\"", 13253, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                <div class=""product-bottom"">
                                    <h3>Smart Watches</h3>
                                    <p>Explore Now</p>
                                    <h4><a class=""item_add"" href=""#""><i></i></a> <span class="" item_price"">$ 329</span></h4>
                                </div>
                                <div class=""srch"">
                                    <span>-50%</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-4 product-left p-left"">
                            <div class=""product-main simpleCart_shelfItem"">
                                <a href=""single.html"" class=""mask""><img class=""img-responsive zoom-img"" src=""images/p-3.png""");
            BeginWriteAttribute("alt", " alt=\"", 14091, "\"", 14097, 0);
            EndWriteAttribute();
            WriteLiteral(@" /></a>
                                <div class=""product-bottom"">
                                    <h3>Smart Watches</h3>
                                    <p>Explore Now</p>
                                    <h4><a class=""item_add"" href=""#""><i></i></a> <span class="" item_price"">$ 329</span></h4>
                                </div>
                                <div class=""srch"">
                                    <span>-50%</span>
                                </div>
                            </div>
                        </div>
                        <div class=""clearfix""></div>
                    </div>
                </div>
            </div>
            <div class=""col-md-3 single-right"">
                <div class=""w_sidebar"">
                    <section class=""sky-form"">
                        <h4>Catogories</h4>
                        <div class=""row1 scroll-pane"">
                            <div class=""col col-4"">
                                <label");
            WriteLiteral(" class=\"checkbox\"><input type=\"checkbox\" name=\"checkbox\"");
            BeginWriteAttribute("checked", " checked=\"", 15178, "\"", 15188, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i></i>All Accessories</label>
                            </div>
                            <div class=""col col-4"">
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Women Watches</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Kids Watches</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Men Watches</label>
                            </div>
                        </div>
                    </section>
                    <section class=""sky-form"">
                        <h4>Brand</h4>
                        <div class=""row1 row2 scroll-pane"">
                            <div class=""col col-4"">
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""");
            BeginWriteAttribute("checked", " checked=\"", 16079, "\"", 16089, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i></i>kurtas</label>
                            </div>
                            <div class=""col col-4"">
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Sonata</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Titan</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Casio</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Omax</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>shree</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Fastrack</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Sports</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""che");
            WriteLiteral(@"ckbox""><i></i>Fossil</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Maxima</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Yepme</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Citizen</label>
                                <label class=""checkbox""><input type=""checkbox"" name=""checkbox""><i></i>Diesel</label>
                            </div>
                        </div>
                    </section>
                    <section class=""sky-form"">
                        <h4>Colour</h4>
                        <ul class=""w_nav2"">
                            <li><a class=""color1"" href=""#""></a></li>
                            <li><a class=""color2"" href=""#""></a></li>
                            <li><a class=""color3"" href=""#""></a></li>
                            <li><a class=""color4"" href=""#""></a></li>
        ");
            WriteLiteral(@"                    <li><a class=""color5"" href=""#""></a></li>
                            <li><a class=""color6"" href=""#""></a></li>
                            <li><a class=""color7"" href=""#""></a></li>
                            <li><a class=""color8"" href=""#""></a></li>
                            <li><a class=""color9"" href=""#""></a></li>
                            <li><a class=""color10"" href=""#""></a></li>
                            <li><a class=""color12"" href=""#""></a></li>
                            <li><a class=""color13"" href=""#""></a></li>
                            <li><a class=""color14"" href=""#""></a></li>
                            <li><a class=""color15"" href=""#""></a></li>
                            <li><a class=""color5"" href=""#""></a></li>
                            <li><a class=""color6"" href=""#""></a></li>
                            <li><a class=""color7"" href=""#""></a></li>
                            <li><a class=""color8"" href=""#""></a></li>
                            <li><a class=""color");
            WriteLiteral(@"9"" href=""#""></a></li>
                            <li><a class=""color10"" href=""#""></a></li>
                        </ul>
                    </section>
                    <section class=""sky-form"">
                        <h4>discount</h4>
                        <div class=""row1 row2 scroll-pane"">
                            <div class=""col col-4"">
                                <label class=""radio""><input type=""radio"" name=""radio""");
            BeginWriteAttribute("checked", " checked=\"", 19609, "\"", 19619, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i></i>60 % and above</label>
                                <label class=""radio""><input type=""radio"" name=""radio""><i></i>50 % and above</label>
                                <label class=""radio""><input type=""radio"" name=""radio""><i></i>40 % and above</label>
                            </div>
                            <div class=""col col-4"">
                                <label class=""radio""><input type=""radio"" name=""radio""><i></i>30 % and above</label>
                                <label class=""radio""><input type=""radio"" name=""radio""><i></i>20 % and above</label>
                                <label class=""radio""><input type=""radio"" name=""radio""><i></i>10 % and above</label>
                            </div>
                        </div>
                    </section>
                </div>
            </div>
            <div class=""clearfix""> </div>
        </div>
    </div>
</div>
<!--end-single-->");
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
