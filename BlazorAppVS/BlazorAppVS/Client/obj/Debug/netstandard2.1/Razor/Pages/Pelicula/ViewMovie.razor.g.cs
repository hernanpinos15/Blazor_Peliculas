#pragma checksum "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8b35a78a43b5f7130f0bdad9dcfa8b9d5842e0a"
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
#nullable restore
#line 13 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{MovieId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pelicula/{MovieId:int}/{NameMovie}")]
    public partial class ViewMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
 if (model == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "Cargando..");
#nullable restore
#line 9 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                           
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "h2");
            __builder.AddContent(3, 
#nullable restore
#line 13 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
         model.Movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " (");
            __builder.AddContent(5, 
#nullable restore
#line 13 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                             model.Movie.ReleaseDate.Value.ToString("yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(6, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 14 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
    for (int i = 0; i < model.Genders.Count; i++)
    {
        if (i < model.Genders.Count - 1)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, 
#nullable restore
#line 18 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
             enlaceGenero(model.Genders[i])

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, ", ");
#nullable restore
#line 18 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                          
        }
        else
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, 
#nullable restore
#line 22 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
             enlaceGenero(model.Genders[i])

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 22 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                           
        }
    }
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, " |  ");
            __builder.OpenElement(12, "span");
            __builder.AddContent(13, 
#nullable restore
#line 25 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                            model.Movie.ReleaseDate.Value.ToString("dd MM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.AddContent(15, " | Promedio: ");
            __builder.AddContent(16, 
#nullable restore
#line 26 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                model.PromedioVotos.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, "/5 | Tu voto: ");
            __builder.AddContent(18, 
#nullable restore
#line 26 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                 model.VotoUsuario.ToString("0.#")

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "style", "display: flex;");
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "span");
            __builder.AddAttribute(23, "style", "display: inline-block; margin-right: 5px;");
            __builder.OpenElement(24, "img");
            __builder.AddAttribute(25, "src", 
#nullable restore
#line 28 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                       model.Movie.Poster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "style", "width: 225px; height: 315px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "iframe");
            __builder.AddAttribute(29, "width", "560");
            __builder.AddAttribute(30, "height", "315");
            __builder.AddAttribute(31, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 29 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                         model.Movie.Trailer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "frameborder", "0");
            __builder.AddAttribute(33, "allow", "accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture");
            __builder.AddAttribute(34, "allowfullscreen", true);
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.AddMarkupContent(40, "<h3>Resumen</h3>\r\n    ");
            __builder.OpenElement(41, "div");
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenComponent<BlazorAppVS.Client.Shared.MostrarMarkdown>(43);
            __builder.AddAttribute(44, "ContenidoMarkdown", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                             model.Movie.Resumen

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "style", "margin-top: 10px;");
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.AddMarkupContent(51, "<h3>Actores</h3>\r\n    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "style", "display: flex; flex-direction: column");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 40 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
         foreach (var actor in model.Actores)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "            ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "style", "margin-bottom: 2px;");
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "img");
            __builder.AddAttribute(60, "style", "width: 50px;");
            __builder.AddAttribute(61, "src", 
#nullable restore
#line 43 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                actor.Foto

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "style", "display:inline-block; width: 200px;");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "href", "/personas/" + (
#nullable restore
#line 44 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                      actor.Id

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 44 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                actor.Nombre.Replace(" ", "-")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, 
#nullable restore
#line 44 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                                                 actor.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.AddMarkupContent(69, "<span style=\"display:inline-block; width: 45px;\">...</span>\r\n                ");
            __builder.OpenElement(70, "span");
            __builder.AddContent(71, 
#nullable restore
#line 46 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                       actor.Personaje

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 48 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n");
#nullable restore
#line 51 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
       
    [Parameter] public int MovieId { get; set; }
    [Parameter] public string NameMovie { get; set; }
    private PeliculaVisualizarDTO model;
    private RenderFragment<Gender> enlaceGenero = (gender) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(77, "a");
            __builder2.AddAttribute(78, "href", "peliculas/buscar?generoid=" + (
#nullable restore
#line 57 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                  gender.Id

#line default
#line hidden
#nullable disable
            ));
            __builder2.AddContent(79, 
#nullable restore
#line 57 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                              gender.Name

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 57 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\Pelicula\ViewMovie.razor"
                                                                                                                             ;

protected async override Task OnInitializedAsync()
{
var responseHttp = await repositorio.Get<PeliculaVisualizarDTO>($"api/movies/{MovieId}");
if (responseHttp.Error)
{
if (responseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
{
navigationManager.NavigateTo("");
}
else
{
var mensajeError = await responseHttp.GetBody();
await mostrarMensajes.MostrarMensajeError(mensajeError);
}
}
else
{
model = responseHttp.Response;
}
}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
