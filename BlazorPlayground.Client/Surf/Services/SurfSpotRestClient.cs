using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor;

namespace BlazorPlayground.Client.Surf.Services
{
    public class SurfSpotRestClient : ISurfSpotClient
    {
        private readonly HttpClient _httpClient;

        public SurfSpotRestClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<SurfSpot>> GetSurfSpots()
        {
            return await _httpClient.GetJsonAsync<SurfSpot[]>("api/SurfSpots");
        }

        public async Task<SurfSpot> GetSurfSpot(int id)
        {
            return await _httpClient.GetJsonAsync<SurfSpot>($"api/SurfSpots/{id}");
        }
    }
}