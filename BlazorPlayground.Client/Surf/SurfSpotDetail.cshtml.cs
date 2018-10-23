using System;
using System.Net.Http;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;

namespace BlazorPlayground.Client.Surf
{
    public class SurfSpotDetailComponent : BlazorComponent
    {
        [Inject] protected HttpClient HttpClient { get; set; }

        [Parameter] protected string Id { get; set; }

        protected SurfSpot SurfSpot;

        protected override async Task OnInitAsync()
        {
            SurfSpot = await HttpClient.GetJsonAsync<SurfSpot>($"api/surfspots/{Id}");
        }
    }
}