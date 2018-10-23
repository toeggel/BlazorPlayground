using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPlayground.Shared.Surf
{
    public class SurfSpotService
    {
        public async Task<SurfSpot> GetSurfSpot(int id)
        {
            return (await GetSurfSpots()).FirstOrDefault(s => s.Id == id);
        }

        public async Task<IEnumerable<SurfSpot>> GetSurfSpots()
        {
            await Task.Delay(100);

            return new List<SurfSpot>
            {
                new SurfSpot
                {
                    Id = 1,
                    Name = "Baleal",
                    Description = "Crowded",
                    BestTide = "Anytime",
                    BreakType = BreakType.BeachBreak,
                    WaveType = WaveType.Anything
                },
                new SurfSpot
                {
                    Id = 2,
                    Name = "Foz do Lizandro",
                    Description = "Closeouts",
                    BestTide = "Anytime",
                    BreakType = BreakType.BeachBreak,
                    WaveType = WaveType.Anything
                },
                new SurfSpot
                {
                    Id = 3,
                    Name = "Foz do Lizandro - Reef 1",
                    Description = "Big",
                    BestTide = "Mid",
                    BreakType = BreakType.Reef,
                    WaveType = WaveType.Right
                },
                new SurfSpot
                {
                    Id = 4,
                    Name = "Foz do Lizandro - Reef 2",
                    Description = "Good",
                    BestTide = "Mid-Low",
                    BreakType = BreakType.Reef,
                    WaveType = WaveType.Right
                },
                new SurfSpot
                {
                    Id = 5,
                    Name = "Praia do Sul",
                    Description = "Protected and therefore smaller",
                    BestTide = "Mid-High",
                    BreakType = BreakType.Point,
                    WaveType = WaveType.Right
                }
            };
        }
    }
}