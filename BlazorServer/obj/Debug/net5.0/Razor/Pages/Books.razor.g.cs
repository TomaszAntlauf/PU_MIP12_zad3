#pragma checksum "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efff3355492e71094b99658210958cdeded5266a"
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
#line 2 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Books")]
    public partial class Books : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Books</h1>");
#nullable restore
#line 7 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
 if (!EditMode && !BindMode && !DelMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
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
                <th>Title</th>
                <th>Release Date</th>
                <th>Average Rates</th>
                <th>Rates Count</th>
                <th>Authors</th>
                <th>Description</th>
                <th>Rate</th>
                <th>Edit</th>
                <th>Add an Author</th>
                <th>Delete</th></tr></thead>
        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 27 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
             foreach (var d in data)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 30 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 31 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 32 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 33 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.AvarageRates

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.RatesCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 35 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     string.Join(", ", d.Authors.Select(x => x.FirstName + " " + x.SecondName).ToArray())

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, 
#nullable restore
#line 36 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     d.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "td");
#nullable restore
#line 38 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                     for (int i = 1; i <= 5; i++)
                    {
                        int x = i;

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                          ()=>ocen(d,x)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, 
#nullable restore
#line 41 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                                          i

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "td");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                                    () =>choose(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "class", "oi oi-cog");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                                    () =>bind(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "oi oi-plus");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                ");
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "button");
            __builder.AddAttribute(51, "type", "button");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                                    ()=>delete(d)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "class", "oi oi-trash");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
}
else if (EditMode && !BindMode && !DelMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.EditAddBook>(54);
            __builder.AddAttribute(55, "originalModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.DTO.BookDTO>(
#nullable restore
#line 54 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                                clickedModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(56, "\r\n    ");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                      onClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "btn btn-primary");
            __builder.AddMarkupContent(60, "Powr??t");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
}
else if (BindMode && !EditMode && !DelMode)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.BookBind>(61);
            __builder.AddAttribute(62, "originalModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.DTO.BookDTO>(
#nullable restore
#line 59 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                             clickedModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(63, "\r\n    ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                      onClick2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "btn btn-primary");
            __builder.AddMarkupContent(67, "Powr??t");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorServer.Pages.BookDelete>(68);
            __builder.AddAttribute(69, "originalModel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.DTO.BookDTO>(
#nullable restore
#line 64 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                               clickedModel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(70, "\r\n    ");
            __builder.OpenElement(71, "button");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
                      onClick3

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "class", "btn btn-primary");
            __builder.AddMarkupContent(74, "Powr??t");
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\Books.razor"
      

    protected List<BookDTO> data;
    PaginationDTO paginationDTO = new PaginationDTO(0, 100);


    protected override async Task OnInitializedAsync()
    {
        data = repo.GetBooks(paginationDTO);
    }

    bool EditMode = false;
    bool BindMode = false;
    bool DelMode = false;
    BookDTO clickedModel = null;

    void onClick()
    {
        clickedModel = null;
        EditMode = !EditMode;
        data = repo.GetBooks(paginationDTO);

    }
    void onClick2()
    {
        clickedModel = null;
        BindMode = false;
        data = repo.GetBooks(paginationDTO);
    }
    void onClick3()
    {
        clickedModel = null;
        DelMode = false;
        data = repo.GetBooks(paginationDTO);
    }
    void choose(BookDTO book)
    {
        clickedModel = book;
        EditMode = true;
    }

    void bind(BookDTO book2)
    {
        clickedModel = book2;
        BindMode = true;
    }
    void delete(BookDTO aut3)
    {
        clickedModel = aut3;
        DelMode = true;
    }

    void ocen(BookDTO book, int rate)
    {
        repo.AddBookRate(book.Id, rate);
        data = repo.GetBooks(paginationDTO);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BooksRepository repo { get; set; }
    }
}
#pragma warning restore 1591
