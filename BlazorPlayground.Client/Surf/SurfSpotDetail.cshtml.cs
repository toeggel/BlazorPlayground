using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using BlazorPlayground.Client.Shared;
using BlazorPlayground.Client.Surf.Services;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;

namespace BlazorPlayground.Client.Surf
{
    public class SurfSpotDetailComponent : BlazorComponent
    {
        [Parameter] protected string Id { get; set; }

        protected SurfSpot SurfSpot;

        protected bool IsEditable;

        protected ElementRef SpotNameInput;

        [Inject] private ISurfSpotClient SurfSpotClient { get; set; }

        protected override async Task OnInitAsync()
        {
            SurfSpot = await SurfSpotClient.GetSurfSpot(Convert.ToInt32(Id));
        }

        protected void EnableEdit()
        {
            IsEditable = true;
            SpotNameInput.Focus();
        }

        protected async Task Save()
        {
            IsEditable = false;

            // Call our function with an object. It will be serialized (JSON),
            // passed to JS-part of Blazor and deserialized into a JavaScript
            // object again.
            // Currently causes a javascript error related to serialization. It seems to work correctly anyway. Unsure why the error is occurs
            await JSRuntime.Current.InvokeAsync<bool>("M.toast", new { html = "Saved!" });
        }
    }
}