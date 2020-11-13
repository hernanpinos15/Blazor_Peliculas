#pragma checksum "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Shared\MoviesLists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bf230d4a8c1a4bf6534f124985796d6f83aa29"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppVS.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class MoviesLists : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Shared\MoviesLists.razor"
       

    Confirmacion confirmacion;
    [Parameter] public List<Movie> Movies { get; set; }

    protected override void OnInitialized()
    {
        Console.WriteLine($"OnInitialized - Cantidad Peliculas: {Movies.Count.ToString()}");
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine($"OnParametersSet - Cantidad Peliculas: {Movies.Count}");
    }

    protected override void OnAfterRender(bool primerRenderizacion)
    {
        Console.WriteLine($"OnAfterRender: Primera vez: {primerRenderizacion}");
    }

    protected override bool ShouldRender()
    {
        Console.WriteLine("ShouldRender");
        return true;
    }

    bool displayButtons = true;

    async Task MovieDelete(Movie movie)
    {
        //var confirmado = await js.Confirm($"¿Desea borrar la película {movie.Title}?");
        //if (confirmado)
        //{
        //    Movies.Remove(movie);
        //    Console.WriteLine($"Se ha eliminado una pelicula {movie.Title}");
        //}
        confirmacion.Mostrar();
        movieDelete = movie;

    }

    Movie movieDelete;
    void EliminarPeliculaConfirmacion()
    {
        Movies.Remove(movieDelete);
        movieDelete = null;
        confirmacion.Ocultar();
    }

    void onCancelConfirmacion()
    {
        confirmacion.Ocultar();
        movieDelete = null;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
