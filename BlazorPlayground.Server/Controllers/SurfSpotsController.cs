using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPlayground.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfSpotsController : ControllerBase
    {
        [HttpGet]
        public async Task<IEnumerable<SurfSpot>> SurfSpots()
        {
            await Task.Delay(500);
            return SurfSpotService.GetSurfSpots();
        }
    }
}