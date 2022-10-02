namespace WebApplication1.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Model { get; set; } = null!;
        public string OperatingSystem { get; set; } = null!;
        public int RAM { get; set; }
        public int BuiltInMemory { get; set; }
        public int NumberOfCores { get; set; }
        public int BatteryCapacity { get; set; }//мА·год
        public float ScreenDiagonal { get; set; }
        public int Price { get; set; }
    }
}
