#pragma checksum "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ba8472134df11e86f346054db913bacd955e78"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppVS.Client.Pages.Pelicula
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/peliculas/buscar")]
    public partial class FiltroMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FiltroMovie</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-inline");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-2");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<label for=\"titulo\" class=\"sr-only\">Título</label>\r\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 10 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                              (KeyboardEventArgs e) => TituloKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "type", "text");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "id", "titulo");
            __builder.AddAttribute(13, "placeholder", "Título Película");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                            titulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => titulo = __value, titulo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                            generoSeleccionado

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => generoSeleccionado = __value, generoSeleccionado));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "0");
            __builder.AddMarkupContent(28, "--Seleccione un género--");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 16 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
             foreach (var item in generos)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 18 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, 
#nullable restore
#line 18 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 19 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(40, "\r\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "class", "form-check-input");
            __builder.AddAttribute(44, "id", "estrenos");
            __builder.AddAttribute(45, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                                                             futurosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => futurosEstrenos = __value, futurosEstrenos));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.AddMarkupContent(48, "<label class=\"form-check-label\" for=\"estrenos\">\r\n            Futuros Estrenos\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "checkbox");
            __builder.AddAttribute(55, "class", "form-check-input");
            __builder.AddAttribute(56, "id", "cartelera");
            __builder.AddAttribute(57, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                                                              enCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => enCartelera = __value, enCartelera));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.AddMarkupContent(60, "<label class=\"form-check-label\" for=\"cartelera\">\r\n            En Cartelera\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "type", "checkbox");
            __builder.AddAttribute(67, "class", "form-check-input");
            __builder.AddAttribute(68, "id", "masVotadas");
            __builder.AddAttribute(69, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                                                               masVotadas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => masVotadas = __value, masVotadas));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n        ");
            __builder.AddMarkupContent(72, "<label class=\"form-check-label\" for=\"masVotadas\">\r\n            Más Votadas\r\n        </label>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                                                         CargarNuevasPeliculas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(78, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n    ");
            __builder.OpenElement(80, "button");
            __builder.AddAttribute(81, "type", "button");
            __builder.AddAttribute(82, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                                                                LimpiarOnClick

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(84, "Limpiar");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n\r\n");
            __builder.OpenComponent<BlazorAppVS.Client.Shared.MoviesLists>(87);
            __builder.AddAttribute(88, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorAppVS.Shared.Entities.Movie>>(
#nullable restore
#line 44 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
                     Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\FiltroMovie.razor"
       

    string titulo = "";
    string generoSeleccionado = "0";
    private bool futurosEstrenos = false;
    private bool enCartelera = false;
    private bool masVotadas = false;
    private List<Movie> Movies;

    private List<Gender> generos = new List<Gender>();

    private void TituloKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Ente")
        {
            CargarNuevasPeliculas();
        }
    }

    private void CargarNuevasPeliculas()
    {
        Movies = Movies.Where(x => x.Title.ToLower().Contains(titulo.ToLower())).ToList();
        Console.WriteLine($"titulo {titulo}");
        Console.WriteLine($"GS {generoSeleccionado}");
        Console.WriteLine($"EC {enCartelera}");
        Console.WriteLine($"FE {futurosEstrenos}");
        Console.WriteLine($"MV {masVotadas}");

    }

    private void LimpiarOnClick()
    {
        Movies = repositorio.ObtenerPeliculas();
        titulo = "";
        generoSeleccionado = "0";
        futurosEstrenos = false;
        enCartelera = false;
        masVotadas = false;
    }

    protected override void OnInitialized()
    {
        Movies = repositorio.ObtenerPeliculas();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591