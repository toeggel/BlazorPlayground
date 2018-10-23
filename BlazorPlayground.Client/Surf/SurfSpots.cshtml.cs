using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPlayground.Client.Surf.Services;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorPlayground.Client.Surf
{
    public class SurfSpotsComponent : BlazorComponent
    {
        protected IEnumerable<SurfSpot> SurfSpots = new List<SurfSpot>();
        [Inject] private ISurfSpotClient SurfSpotClient { get; set; }

        protected override async Task OnInitAsync()
        {
            SurfSpots = await SurfSpotClient.GetSurfSpots();
        }
    }
}