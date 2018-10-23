using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorPlayground.Client.Surf
{
    public class SurfSpotsComponent : BlazorComponent
    {
        protected IEnumerable<SurfSpot> SurfSpots = new List<SurfSpot>();
        [Inject] private HttpClient HttpClient { get; set; }

        protected override async Task OnInitAsync()
        {
            SurfSpots = await HttpClient.GetJsonAsync<SurfSpot[]>("api/SurfSpots");
        }
    }
}