#pragma checksum "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookDelete.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4586ee3923cf4d4278a0b7d09f526ba4057d634"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using BlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using BlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\_Imports.razor"
using Repository_Pattern;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookDelete.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Books/delete")]
    public partial class BookDelete : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "width:22rem");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "<h3 class=\"card-title\">Usuwanie</h3>\r\n        ");
            __builder.AddMarkupContent(6, "<p class=\"card-text\">Czy na pewno chcesz usunąć?</p>\r\n        ");
            __builder.OpenElement(7, "button");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookDelete.razor"
                          onYes

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Tak");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookDelete.razor"
       

    [Parameter]
    public BookDTO originalModel { get; set; }

    public void onYes()
    {
        repo.DeleteDTO(originalModel.Id);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BooksRepository repo { get; set; }
    }
}
#pragma warning restore 1591
