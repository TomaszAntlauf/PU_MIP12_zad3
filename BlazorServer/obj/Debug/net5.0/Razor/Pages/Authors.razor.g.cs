#pragma checksum "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9625647a435121f60cb6daa9beaf6c1424d4c586"
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
#line 2 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Authors")]
    public partial class Authors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Authors</h1>");
#nullable restore
#line 7 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
 if (!EditMode && !BindMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                      onClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "btn btn-primary");
            __builder.AddContent(4, "Dodaj");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table tabela");
            __builder.AddMarkupContent(8, @"<thead><tr><th>Id</th>
                <th>First Name</th>
                <th>Second Name</th>
                <th>Average Rates</th>
                <th>Rates Count</th>
                <th>Books</th>
                <th>CV</th>
                <th>Rate</th>
                <th>Edit</th>
                <th>Add a book</th></tr></thead>
        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 26 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
             foreach (var d in data)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.SecondName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 32 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.AvarageRates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                    ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 33 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.RatesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 34 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         display(d)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 35 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         d.CV

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 37 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                         for (int i = 1; i <= 5; i++)
                        {
                            int x = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                                              ()=>ocen(d,x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, 
#nullable restore
#line 40 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                                                              i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                                                        () =>choose(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "oi oi-cog");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                                                        () =>bind(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "oi oi-plus");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
}
else if (EditMode && !BindMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.AddEditAuthor>(48);
            __builder.AddAttribute(49, "originalModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.DTO.AuthorDTO>(
#nullable restore
#line 52 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                                  clickedModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                      onClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddMarkupContent(54, "Powrót");
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.AuthorBind>(55);
            __builder.AddAttribute(56, "originalModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.DTO.AuthorDTO>(
#nullable restore
#line 57 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                               clickedModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n    ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
                      onClick2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "class", "btn btn-primary");
            __builder.AddMarkupContent(61, "Powrót");
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Authors.razor"
      

    protected List<AuthorDTO> data;

    protected override async Task OnInitializedAsync()
    {
        PaginationDTO paginationDTO = new PaginationDTO(0, 100);

        data = repo.GetAuthors(paginationDTO);
    }

    bool EditMode = false;
    bool BindMode = false;
    AuthorDTO clickedModel = null;

    void onClick()
    {
        clickedModel = null;
        EditMode = !EditMode;
    }
    void onClick2()
    {
        clickedModel = null;
        BindMode = false;
    }
    void choose(AuthorDTO aut)
    {
        clickedModel = aut;
        EditMode = true;
    }
    void bind(AuthorDTO aut2)
    {
        clickedModel = aut2;
        BindMode = true;
    }

    string display(AuthorDTO aut)
    {
        if (aut.Books.Count > 3)
        {
            var books = aut.Books.Select(x => x.Title).Take(3);
            return string.Join(" ,", books) + "+".ToString();
        }
        else
        {
            return string.Join(" ,", aut.Books.Select(x => x.Title).ToArray());
        }
    }

    void ocen(AuthorDTO aut, int rate)
    {
        repo.AddAuthorRate(aut.Id, rate);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorRepository repo { get; set; }
    }
}
#pragma warning restore 1591
