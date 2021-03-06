#pragma checksum "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad21b396a63affe948549582ee3d987c98b078ad"
// <auto-generated/>
#pragma warning disable 1591
namespace SocialMarket.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/contact")]
    public partial class ContactUs : ContactUsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<SocialMarket.Shared.PageTitle>(0);
            __builder.AddAttribute(1, "PageTitleText", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                           PageTitleText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "contact-area pb-100");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "<div class=\"section-title\"><span class=\"sub-title\">Get in Touch</span>\r\n            <h2>Ready to Get Started?<span class=\"overlay\"></span></h2>\r\n            <p>Your email address will not be published. Required fields are marked *</p></div>\r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.AddMarkupContent(10, "<div class=\"col-lg-6 col-md-12\"><div class=\"contact-image\" data-tilt><img src=\"/img/contact.png\" alt=\"image\"></div></div>\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-lg-6 col-md-12");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "contact-form");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(15);
            __builder.AddAttribute(16, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 27 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                      ContactusEmailModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                          SaveContactUs

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(18, "id", "contactForm");
            __builder.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(20);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "row");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-lg-12 col-md-6");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "name");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "placeholder", "Your name");
                __builder2.AddAttribute(32, "required", true);
                __builder2.AddAttribute(33, "data-error", "Please enter your name");
                __builder2.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                                                 ContactusEmailModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ContactusEmailModel.Name = __value, ContactusEmailModel.Name))));
                __builder2.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ContactusEmailModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "                                    \r\n                                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "help-block with-errors");
                __Blazor.SocialMarket.Pages.ContactUs.TypeInference.CreateValidationMessage_0(__builder2, 40, 41, 
#nullable restore
#line 36 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                  () => ContactusEmailModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col-lg-12 col-md-6");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "class", "form-control");
                __builder2.AddAttribute(49, "id", "email");
                __builder2.AddAttribute(50, "required", true);
                __builder2.AddAttribute(51, "data-error", "Please enter your email");
                __builder2.AddAttribute(52, "placeholder", "Your email address");
                __builder2.AddAttribute(53, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                                                                                   ContactusEmailModel.EmailAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ContactusEmailModel.EmailAddress = __value, ContactusEmailModel.EmailAddress))));
                __builder2.AddAttribute(55, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ContactusEmailModel.EmailAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "                                    \r\n                                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "help-block with-errors");
                __Blazor.SocialMarket.Pages.ContactUs.TypeInference.CreateValidationMessage_1(__builder2, 59, 60, 
#nullable restore
#line 45 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                  () => ContactusEmailModel.EmailAddress

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "col-lg-12 col-md-12");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "phone_number");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "required", true);
                __builder2.AddAttribute(70, "data-error", "Please enter your phone number");
                __builder2.AddAttribute(71, "placeholder", "Your phone number");
                __builder2.AddAttribute(72, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                                             ContactusEmailModel.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ContactusEmailModel.PhoneNumber = __value, ContactusEmailModel.PhoneNumber))));
                __builder2.AddAttribute(74, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ContactusEmailModel.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(75, "                                    \r\n                                    ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "help-block with-errors");
                __Blazor.SocialMarket.Pages.ContactUs.TypeInference.CreateValidationMessage_2(__builder2, 78, 79, 
#nullable restore
#line 56 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                  () => ContactusEmailModel.PhoneNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-lg-12 col-md-12");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "form-group");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(85);
                __builder2.AddAttribute(86, "id", "message");
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "cols", "30");
                __builder2.AddAttribute(89, "rows", "6");
                __builder2.AddAttribute(90, "required", true);
                __builder2.AddAttribute(91, "data-error", "Please enter your message");
                __builder2.AddAttribute(92, "placeholder", "Write your message...");
                __builder2.AddAttribute(93, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 64 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                                                     ContactusEmailModel.Message

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ContactusEmailModel.Message = __value, ContactusEmailModel.Message))));
                __builder2.AddAttribute(95, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ContactusEmailModel.Message));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(96, "                                    \r\n                                    ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "help-block with-errors");
                __Blazor.SocialMarket.Pages.ContactUs.TypeInference.CreateValidationMessage_3(__builder2, 99, 100, 
#nullable restore
#line 66 "E:\Manu\SocialMarket\SocialMarket\SocialMarket\Pages\ContactUs.razor"
                                                                  () => ContactusEmailModel.Message

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                            ");
                __builder2.AddMarkupContent(102, "<div class=\"col-lg-12 col-md-12\"><button type=\"submit\" class=\"default-btn\">Send Message</button>\r\n                                <div id=\"msgSubmit\" class=\"h3 text-center hidden\"></div>\r\n                                <div class=\"clearfix\"></div></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.SocialMarket.Pages.ContactUs
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
