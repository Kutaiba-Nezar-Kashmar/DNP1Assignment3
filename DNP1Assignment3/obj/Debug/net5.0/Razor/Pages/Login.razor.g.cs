#pragma checksum "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e431abe0a57aa614006c6efedb2944a91f43efee"
// <auto-generated/>
#pragma warning disable 1591
namespace DNP1Assignment3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 3 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
using DNP1Assignment3.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
using DNP1Assignment3.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(2, "div");
                __builder2.AddAttribute(3, "class", "LogPageDis");
                __builder2.AddMarkupContent(4, "<p class=\"WelcomeMessage\" align=\"center\">Sign in</p>\r\n            ");
                __builder2.OpenElement(5, "form");
                __builder2.AddAttribute(6, "class", "formDis");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "class", "inputField");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "placeholder", "User name");
                __builder2.AddAttribute(11, "required", "required");
                __builder2.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                                                                                               userName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n                ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "class", "inputField");
                __builder2.AddAttribute(17, "type", "password");
                __builder2.AddAttribute(18, "placeholder", "password");
                __builder2.AddAttribute(19, "required", "required");
                __builder2.AddAttribute(20, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                                                                                                  password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenElement(23, "p");
                __builder2.AddAttribute(24, "class", "errorMessage");
                __builder2.AddContent(25, 
#nullable restore
#line 16 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                         errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "buttonsDis");
                __builder2.OpenElement(29, "a");
                __builder2.AddAttribute(30, "class", "submit");
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                                PerformLogin

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(32, "Sign in");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "a");
                __builder2.AddAttribute(35, "class", "submit");
                __builder2.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                                ToCreateUserPage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(37, "Sign up");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __builder2.AddMarkupContent(39, "<p class=\"guest\" align=\"center\"><a href=\"Adults\">Continue as aguest</a></p>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(40, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.OpenElement(43, "button");
                __builder2.AddAttribute(44, "class", "submit");
                __builder2.AddAttribute(45, "type", "submit");
                __builder2.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
                                                           PerformLogout

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(47, "Log out");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\kkash\RiderProjects\DNP1Assignment3\DNP1Assignment3\Pages\Login.razor"
 
    private string userName;
    private string password;
    private string errorMessage;

    public async Task PerformLogin()
    {
        errorMessage = "";
        try
        {
           await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(userName, password);
            NavigationManager.NavigateTo("/Adults");
            userName = "";
            password = "";
        }
        catch (Exception e)
        {
            errorMessage = e.Message;
        }
    }

    public async Task PerformLogout()
    {
        errorMessage = "";
        userName = "";
        password = "";
        try
        {
            ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
        }
        catch (Exception e)
        {
        }
    }
    
    private void ToCreateUserPage()
    {
        NavigationManager.NavigateTo("/CreateUser");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591