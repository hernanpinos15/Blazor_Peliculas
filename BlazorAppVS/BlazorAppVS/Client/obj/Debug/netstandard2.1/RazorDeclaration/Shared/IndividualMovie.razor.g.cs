#pragma checksum "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\Shared\IndividualMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0571ed2282c69a0abcc2216235757aa5089fad02"
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
#line 1 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\_Imports.razor"
using BlazorAppVS.Client.Repositorios;

#line default
#line hidden
#nullable disable
    public partial class IndividualMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "H:\HP\1. Portafolio\BlazorAppVS\BlazorAppVS\Client\Shared\IndividualMovie.razor"
       
    [Parameter] public Movie Movie { get; set; }
    [Parameter] public bool DisplayButtons { get; set; } = false;
    [Parameter] public EventCallback<Movie> MovieDelete { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
