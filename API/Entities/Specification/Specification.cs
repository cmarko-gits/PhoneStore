
namespace API.Entitiees.Specification{
    public class Specification
    {
        public Brand Brand { get; set; }
        public Os OperatingSystem { get; set; }
        public string CPU { get; set; }
        public float ScreenSize { get; set; }
        public string ScreenType { get; set; }
        public int RAM { get; set; }
        public int InternalStorage { get; set; }
        public int BatteryCapacity { get; set; }
        public bool FastCharging { get; set; }
        public int FastChargingWatt { get; set; }
        public bool WirelessCharging { get; set; }
    }

    // CameraSpecifications kao kompleksni tip
    public class Camera
{
    public string CameraType { get; set; }
    public bool IsStabilized { get; set; }
    public int Megapixels { get; set; }
}


    

}