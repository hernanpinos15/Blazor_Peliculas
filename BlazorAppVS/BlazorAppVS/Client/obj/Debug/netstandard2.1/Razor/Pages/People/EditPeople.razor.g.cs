#pragma checksum "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\People\EditPeople.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b9dc94ca847490f84abb508f4a23bf4448f75ad"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorAppVS.Client.Pages.People
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas/editar/{PeopleId:int}")]
    public partial class EditPeople : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Persona</h3>\r\n\r\n");
            __builder.OpenComponent<BlazorAppVS.Client.Pages.People.FormularioPeople>(1);
            __builder.AddAttribute(2, "People", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorAppVS.Shared.Entities.People>(
#nullable restore
#line 5 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\People\EditPeople.razor"
                          People

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 5 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\People\EditPeople.razor"
                                                 Editar

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "H:\HP\1. Portafolio\WebAssembly_Blazor_Peliculas\BlazorAppVS\BlazorAppVS\Client\Pages\People\EditPeople.razor"
       
    [Parameter] public int PeopleId { get; set; }

    People People = new People();

    protected override void OnInitialized()
    {
        People = new People()
        {
            Id = PeopleId,
            Nombre = "HP",
            FechaNacimiento = DateTime.Today
        };
    }

    private void Editar()
    {
        Console.WriteLine("Editando a la persona");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
