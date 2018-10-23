namespace BlazorPlayground.Shared.Surf
{
    public class SurfSpot
    {
        public string Name { get; set; }
        public BreakType BreakType { get; set; }
        public WaveType WaveType { get; set; }
        public string BestTide { get; set; }
        public string Description { get; set; }
    }


    public enum BreakType
    {
        BeachBreak,
        Reef,
        Point
    }

    public enum WaveType
    {
        Left,
        Right,
        AFrame
    }
}