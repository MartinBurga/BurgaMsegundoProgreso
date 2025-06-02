using BurgaMsegundoProgreso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BurgaMsegundoProgreso
{
    class JokesService
    {
        private readonly HttpClient _httpClient;
        public JokesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Chiste> GetRandomJokeAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://official-joke-api.appspot.com/random_joke");
                Chiste joke = await response.Content.ReadFromJsonAsync<Chiste>();
                return joke;

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
