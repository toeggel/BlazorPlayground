using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPlayground.Shared.Surf;

namespace BlazorPlayground.Client.Surf.Services
{
    public interface ISurfSpotClient
    {
        Task<IEnumerable<SurfSpot>> GetSurfSpots();
        Task<SurfSpot> GetSurfSpot(int id);
    }
}