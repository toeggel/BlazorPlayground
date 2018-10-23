using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;

namespace BlazorPlayground.Client.Surf.Services
{
    public class SurfSpotWebSocketClient : ISurfSpotClient
    {
        private readonly SurfSpotService _surfSpotService;

        public SurfSpotWebSocketClient(SurfSpotService surfSpotService)
        {
            _surfSpotService = surfSpotService;
        }

        public async Task<IEnumerable<SurfSpot>> GetSurfSpots()
        {
            return await _surfSpotService.GetSurfSpots();
        }

        public async Task<SurfSpot> GetSurfSpot(int id)
        {
            return await _surfSpotService.GetSurfSpot(id);
        }
    }
}