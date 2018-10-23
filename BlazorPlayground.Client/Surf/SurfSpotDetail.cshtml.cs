using System;
using System.Threading.Tasks;
using BlazorPlayground.Client.Surf.Services;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorPlayground.Client.Surf
{
    public class SurfSpotDetailComponent : BlazorComponent
    {
        protected SurfSpot SurfSpot;
        [Parameter] protected string Id { get; set; }

        [Inject] private ISurfSpotClient SurfSpotClient { get; set; }

        protected override async Task OnInitAsync()
        {
            SurfSpot = await SurfSpotClient.GetSurfSpot(Convert.ToInt32(Id));
        }
    }
}