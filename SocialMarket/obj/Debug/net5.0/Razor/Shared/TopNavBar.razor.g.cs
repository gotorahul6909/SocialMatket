#pragma checksum "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c4782efd0864c236a1f89a7ecd33f8cd714cb05"
// <auto-generated/>
#pragma warning disable 1591
namespace SocialMarket.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using SocialMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using SocialMarket.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using SocialMarket.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\_Imports.razor"
using SocialMarket.Models;

#line default
#line hidden
#nullable disable
    public partial class TopNavBar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "navbar-area navbar-style-two");
            __builder.AddMarkupContent(2, "<div class=\"dibiz-responsive-nav\"><div class=\"container\"><div class=\"dibiz-responsive-menu\"><div class=\"logo\"><a href=\"index-4.html\"><img src=\"/img/logo.png\" alt=\"logo\"></a></div></div></div></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "dibiz-nav");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenElement(7, "nav");
            __builder.AddAttribute(8, "class", "navbar navbar-expand-md navbar-light");
            __builder.AddMarkupContent(9, "<a class=\"navbar-brand\" href=\"index-4.html\"><img src=\"/img/logo.png\" alt=\"logo\"></a>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "collapse navbar-collapse mean-menu");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "navbar-nav");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "href", "/");
            __builder.AddAttribute(18, "class", "nav-link");
            __builder.AddAttribute(19, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 36 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor"
                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "<span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "li");
            __builder.AddAttribute(24, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
            __builder.AddAttribute(26, "href", "/about-us");
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 41 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor"
                                                                              NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "\r\n                                About\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "nav-item");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(34);
            __builder.AddAttribute(35, "href", "/contact");
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 46 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor"
                                                                             NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "\r\n                                Contact\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(41);
            __builder.AddAttribute(42, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(43, "li");
                __builder2.AddAttribute(44, "class", "nav-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(45);
                __builder2.AddAttribute(46, "href", "/identity/account/login");
                __builder2.AddAttribute(47, "class", "nav-link");
                __builder2.AddAttribute(48, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 53 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor"
                                                                                                    NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(50, "<span class=\"oi oi-lock-locked\" aria-hidden=\"true\"></span> Login\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(51, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(52, "li");
                __builder2.AddAttribute(53, "class", "nav-item");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(54);
                __builder2.AddAttribute(55, "href", "/identity/account/logout");
                __builder2.AddAttribute(56, "class", "nav-link");
                __builder2.AddAttribute(57, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 60 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Shared\TopNavBar.razor"
                                                                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(59, "<span class=\"oi oi-power-standby\" aria-hidden=\"true\"></span> Logout\r\n                                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
