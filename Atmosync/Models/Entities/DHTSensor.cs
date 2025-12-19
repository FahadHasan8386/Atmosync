namespace Atmosync.Api.Models.Entities
{
    public class DHTSensor
    {
        public long Id { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public string CreatedBy { get; set; } = "fahad";
        public DateTime CreatedAt { get; set; }
    }
}
