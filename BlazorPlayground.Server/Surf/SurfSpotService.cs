using System.Collections.Generic;
using BlazorPlayground.Shared.Surf;

namespace BlazorPlayground.Server.Surf
{
    public class SurfSpotService
    {
        public IEnumerable<SurfSpot> GetSurfSpots()
        {
            yield return new SurfSpot
            {
                Name = "Baleal",
                Description = "Crowded",
                BestTide = "Anytime",
                BreakType = BreakType.BeachBreak,
                WaveType = WaveType.Anything
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro",
                Description = "Closeouts",
                BestTide = "Anytime",
                BreakType = BreakType.BeachBreak,
                WaveType = WaveType.Anything
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro - Reef 1",
                Description = "Big",
                BestTide = "Mid",
                BreakType = BreakType.Reef,
                WaveType = WaveType.Right
            };

            yield return new SurfSpot
            {
                Name = "Foz do Lizandro - Reef 2",
                Description = "Good",
                BestTide = "Mid-Low",
                BreakType = BreakType.Reef,
                WaveType = WaveType.Right
            };

            yield return new SurfSpot
            {
                Name = "Praia do Sul",
                Description = "Protected and therefore smaller",
                BestTide = "Mid-High",
                BreakType = BreakType.Point,
                WaveType = WaveType.Right
            };
        }
    }
}