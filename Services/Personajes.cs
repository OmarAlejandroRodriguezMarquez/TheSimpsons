
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace TheSimpsons.Services
{
    public class Personajes : IPersonajes
    {
        private readonly HttpClient http;

        public Personajes(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Result>> GetPersonajesAsync()
        {
            var json = await http.GetStringAsync("https://thesimpsonsapi.com/api/characters");
            var lista = Resultado.FromJson(json);
            var personajes = lista.Results;
            return personajes;
        }
    }
}
