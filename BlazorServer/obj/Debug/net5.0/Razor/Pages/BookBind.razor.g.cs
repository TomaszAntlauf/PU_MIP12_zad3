#pragma checksum "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ddab15d513b23711d4c9332a35ff08b7232db0"
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor"
                 model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor"
                                       OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n\r\n    ");
                __builder2.AddMarkupContent(8, "<label>Author Id:</label>\r\n    ");
                __Blazor.BlazorServer.Pages.BookBind.TypeInference.CreateInputNumber_0(__builder2, 9, 10, 
#nullable restore
#line 12 "C:\Users\tomaa\source\repos\PU-MIP12-zad3\BlazorServer\Pages\BookBind.razor"
                              aut

#line default
#line hidden
#nullable disable
                , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => aut = __value, aut)), 12, () => aut);
                __builder2.AddMarkupContent(13, "\r\n\r\n    ");
                __builder2.AddMarkupContent(14, "<button>Dodaj</button>");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.BlazorServer.Pages.BookBind
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591