#pragma checksum "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Shared\SelectorMultiple.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01c41cfdf3faa01bf70e4eeb1b74b410870a2e7e"
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
    public partial class SelectorMultiple : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Shared\SelectorMultiple.razor"
       
    private string removerTodoTexto = "<<";
    [Parameter] public List<SelectorMultipleModel> NoSeleccionados { get; set; }
        = new List<SelectorMultipleModel>();
    [Parameter]
    public List<SelectorMultipleModel> Seleccionados { get; set; }
        = new List<SelectorMultipleModel>();

    private void Seleccionar(SelectorMultipleModel item)
    {
        NoSeleccionados.Remove(item);
        Seleccionados.Add(item);
    }

    private void Deseleccionar(SelectorMultipleModel item)
    {
        Seleccionados.Remove(item);
        NoSeleccionados.Add(item);
    }

    private void SeleccionarTodo()
    {
        Seleccionados.AddRange(NoSeleccionados);
        NoSeleccionados.Clear();
    }

    private void DeseleccionarTodo()
    {
        NoSeleccionados.AddRange(Seleccionados);
        Seleccionados.Clear();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
