// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor"
using Model.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Books/bind")]
    public partial class BookBind : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor"
       
    BookRequestDTO model = new BookRequestDTO();
    [Parameter]
    public BookDTO originalModel { get; set; }
    int aut;
    PaginationDTO paginationDTO = new PaginationDTO(0, 100);

    protected override void OnInitialized()
    {
        model.Title = originalModel.Title;
        model.ReleaseDate = originalModel.ReleaseDate;
        model.Description = originalModel.Description;
        model.AuthorsId = originalModel.Authors.Select(x => x.Id).ToList();
    }

    public void OnSubmit()
    {
        if (aut>0||aut<= repo2.GetAuthors(paginationDTO).Count)
        {
            model.AuthorsId.Add(aut);
            repo.PutBook(originalModel.Id, model);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthorRepository repo2 { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BooksRepository repo { get; set; }
    }
}
#pragma warning restore 1591
