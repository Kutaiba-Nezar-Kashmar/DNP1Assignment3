#pragma checksum "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5aec055265539821b98d27a6c6a83e5405688026"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP1Assignment3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using DNP1Assignment3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\_Imports.razor"
using DNP1Assignment3.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
using DNP1Assignment3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
using DNP1Assignment3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.AddMarkupContent(2, "<h3 class=\"warning\">Please <a href=\"Login\"> login</a> in order to view this page</h3>");
            }
            ));
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((Auth) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "editAdultBox");
                __builder2.AddMarkupContent(6, "<br>\r\n            ");
                __builder2.AddMarkupContent(7, "<p class=\"WelcomeMessageCreate\">Please fill the fields:</p>\r\n            ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "addBox");
                __builder2.OpenElement(10, "form");
                __builder2.AddAttribute(11, "class", "formDis");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.AddMarkupContent(14, @"<div class=""col-md-3""><p class=""labels"">First Name:</p>
                            <p class=""labels"">Last Name:</p>
                            <p class=""labels"">Hair Color:</p>
                            <p class=""labels"">Eye Color:</p>
                            <p class=""labels"">Age:</p>
                            <p class=""labels"">Weight:</p>
                            <p class=""labels"">Height:</p>
                            <p class=""labels"">Gender:</p>
                            <p class=""labels"">Job Title:</p>
                            <p class=""labels"">Salary:</p></div>
                        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "col-md-9");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "inputField");
                __builder2.AddAttribute(19, "type", "text");
                __builder2.AddAttribute(20, "placeholder", "First Name");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                        newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.FirstName = __value, newAdult.FirstName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "class", "inputField");
                __builder2.AddAttribute(26, "type", "text");
                __builder2.AddAttribute(27, "placeholder", "Last Name");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                       newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.LastName = __value, newAdult.LastName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "class", "inputField");
                __builder2.AddAttribute(33, "type", "text");
                __builder2.AddAttribute(34, "placeholder", "Hair Color");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                        newAdult.HairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.HairColor = __value, newAdult.HairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "input");
                __builder2.AddAttribute(39, "class", "inputField");
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "placeholder", "Eye Color");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                       newAdult.EyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.EyeColor = __value, newAdult.EyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.OpenElement(45, "input");
                __builder2.AddAttribute(46, "class", "inputField");
                __builder2.AddAttribute(47, "type", "number");
                __builder2.AddAttribute(48, "placeholder", "Age");
                __builder2.AddAttribute(49, "min", "18");
                __builder2.AddAttribute(50, "max", "100");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                                      newAdult.Age

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Age = __value, newAdult.Age, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "class", "inputField");
                __builder2.AddAttribute(56, "type", "number");
                __builder2.AddAttribute(57, "placeholder", "Weight");
                __builder2.AddAttribute(58, "min", "0");
                __builder2.AddAttribute(59, "step", "any");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                                         newAdult.Weight

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Weight = __value, newAdult.Weight, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                            ");
                __builder2.OpenElement(63, "input");
                __builder2.AddAttribute(64, "class", "inputField");
                __builder2.AddAttribute(65, "type", "number");
                __builder2.AddAttribute(66, "placeholder", "Height");
                __builder2.AddAttribute(67, "min", "0");
                __builder2.AddAttribute(68, "step", "any");
                __builder2.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                                         newAdult.Height

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Height = __value, newAdult.Height, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                            ");
                __builder2.OpenElement(72, "input");
                __builder2.AddAttribute(73, "class", "inputField");
                __builder2.AddAttribute(74, "type", "text");
                __builder2.AddAttribute(75, "placeholder", "Sex");
                __builder2.AddAttribute(76, "minlength", "1");
                __builder2.AddAttribute(77, "maxlength", "1");
                __builder2.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                                             newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Sex = __value, newAdult.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                            ");
                __builder2.OpenElement(81, "input");
                __builder2.AddAttribute(82, "class", "inputField");
                __builder2.AddAttribute(83, "type", "text");
                __builder2.AddAttribute(84, "placeholder", "Job title");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                       newAdult.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.JobTitle.JobTitle = __value, newAdult.JobTitle.JobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.OpenElement(88, "input");
                __builder2.AddAttribute(89, "class", "inputField");
                __builder2.AddAttribute(90, "type", "number");
                __builder2.AddAttribute(91, "placeholder", "Salary");
                __builder2.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                                                                      newAdult.JobTitle.Salary

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.JobTitle.Salary = __value, newAdult.JobTitle.Salary, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "d-flex justify-content-center AddFBu");
                __builder2.OpenElement(97, "a");
                __builder2.AddAttribute(98, "class", "submit");
                __builder2.AddAttribute(99, "type", "submit");
                __builder2.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
                                                          AddAdult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(101, "Add To Adults");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\AddAdults.razor"
 
    private Adult newAdult = new Adult(){JobTitle = new Job()};

    private async Task AddAdult()
    {
        try
        {
            await AdultData.AddAdult(newAdult);
            NavigationManager.NavigateTo("/Adults");
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultData AdultData { get; set; }
    }
}
#pragma warning restore 1591
