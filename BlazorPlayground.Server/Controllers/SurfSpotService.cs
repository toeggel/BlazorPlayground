using System.Collections.Generic;
using BlazorPlayground.Shared.Surf;

namespace BlazorPlayground.Server.Controllers
{
    public class SurfSpotService
    {
        public static IEnumerable<SurfSpot> GetSurfSpots()
        {
            yield return new SurfSpot
            {
                Name = "Baleal",
                Description = "Crowded"
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro",
                Description = "Closeouts"
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro - Reef 1",
                Description = "Big"
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro - Reef 2",
                Description = "Good"
            };

            yield return new SurfSpot
            {
                Name = "Praia do Sul",
                Description = "Protected and therefore smaller"
            };
        }
    }
}