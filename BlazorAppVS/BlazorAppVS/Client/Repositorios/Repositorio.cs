﻿using BlazorAppVS.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorAppVS.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly HttpClient httpClient;

        public Repositorio(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        private JsonSerializerOptions OpcionesPorDefectoJSON =>
            new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

        public async Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            var responseHTTP = await httpClient.GetAsync(url);
            if (responseHTTP.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<T>(responseHTTP, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<T>(response, false, responseHTTP);
            }
            else
            {
                return new HttpResponseWrapper<T>(default, true, responseHTTP);
            }
        }

        public async Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            return new HttpResponseWrapper<object>(null, !responseHttp.IsSuccessStatusCode, responseHttp);
        }

        public async Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar)
        {
            var enviarJSON = JsonSerializer.Serialize(enviar);
            var enviarContent = new StringContent(enviarJSON, Encoding.UTF8, "application/json");
            var responseHttp = await httpClient.PostAsync(url, enviarContent);
            if (responseHttp.IsSuccessStatusCode)
            {
                var response = await DeserializarRespuesta<TResponse>(responseHttp, OpcionesPorDefectoJSON);
                return new HttpResponseWrapper<TResponse>(response, false, responseHttp);
            }
            else 
            {
                return new HttpResponseWrapper<TResponse>(default, true, responseHttp);
            }
        }

        private async Task<T> DeserializarRespuesta<T>(HttpResponseMessage httpResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(responseString, jsonSerializerOptions);
        }
        public List<Movie> ObtenerPeliculas()
        {
            return new List<Movie>()
            {
                new Movie(){
                    Title = "Spider-Man: un nuevo universo", 
                    ReleaseDate = new DateTime(2020,2,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMjMwNDkxMTgzOF5BMl5BanBnXkFtZTgwNTkwNTQ3NjM@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Ammonite", 
                    ReleaseDate = new DateTime(2019,9,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BZmM3ZGZlMWUtMjY1OS00NjBkLWE4MjQtODJkMmQ1MzdjYzhkXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Los Croods: Una nueva era", 
                    ReleaseDate = new DateTime(2015,1,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BNjUwNjdhM2UtYTcxZC00NTI4LTlhZWMtMGEzNjBiZWI1NzJiXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
                new Movie(){
                    Title = "Monsters of Man", 
                    ReleaseDate = new DateTime(2019,2,2),
                    Poster = "https://m.media-amazon.com/images/M/MV5BMDlkYzRmODAtZjczMy00ODdjLWE4MDUtMzA5YmYwNTVlMTEyXkEyXkFqcGdeQXVyNDQ0MDAxNQ@@._V1_UX182_CR0,0,182,268_AL_.jpg"},
            };
        }
    }
}
