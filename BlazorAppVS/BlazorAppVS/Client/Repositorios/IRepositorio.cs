using BlazorAppVS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAppVS.Client.Repositorios
{
    public interface IRepositorio
    {
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        List<Movie> ObtenerPeliculas();
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
    }
}
