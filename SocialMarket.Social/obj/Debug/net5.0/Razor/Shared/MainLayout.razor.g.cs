#pragma checksum "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d11d3c0add741038cbf54ae35bb10c139ef93d"
// <auto-generated/>
#pragma warning disable 1591
namespace SocialMarket.Social.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using SocialMarket.Social;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using SocialMarket.Social.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using SocialMarket.Social.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\_Imports.razor"
using SocialMarket.Models;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "wrapper");
            __builder.AddAttribute(2, "b-j3jhalwqnw");
            __builder.OpenComponent<SocialMarket.Social.Shared.NavBar>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<SocialMarket.Social.Pages.MainSideBar>(5);
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content-wrapper");
            __builder.AddAttribute(9, "b-j3jhalwqnw");
            __builder.OpenComponent<SocialMarket.Social.Shared.ContentHeader>(10);
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "section");
            __builder.AddAttribute(13, "class", "content");
            __builder.AddAttribute(14, "b-j3jhalwqnw");
            __builder.AddContent(15, 
#nullable restore
#line 10 "E:\Manu\SocialMarket\SocialMarket\SocialMarket.Social\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenComponent<SocialMarket.Social.Pages.Footer>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n    \r\n    ");
            __builder.AddMarkupContent(19, "<aside class=\"control-sidebar control-sidebar-dark\" b-j3jhalwqnw>\r\n        adasdas\r\n        </aside>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
