using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPlayground.Server.Surf
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurfSpotsController : ControllerBase
    {
        public SurfSpotsController(SurfSpotService surfSpotService)
        {
            SurfSpotService = surfSpotService;
        }

        private SurfSpotService SurfSpotService { get; }

        [HttpGet]
        public async Task<IEnumerable<SurfSpot>> SurfSpots()
        {
            return await SurfSpotService.GetSurfSpots();
        }

        [HttpGet("{id}")]
        public async Task<SurfSpot> SurfSpots(int id)
        {
            return await SurfSpotService.GetSurfSpot(id);
        }
    }
}