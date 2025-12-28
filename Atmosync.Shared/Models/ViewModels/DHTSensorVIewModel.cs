namespace Atmosync.Shared.Models.ViewModels
{
    public class DHTSensorVIewModel
    {
        public long Id { get; set; }
        public string TemperatureDisplay { get; set; } = string.Empty;
        public string HumidityDisplay { get; set; } = string.Empty;
        public string Timestamp { get; set; } = string.Empty;
        public string Status { get; set; } = "Normal";
    }
}
