namespace Atmosync.Api.Models.Entities
{
    public class MQ136Sensor
    {
        public long Id { get; set; }
        public int H2SLevel { get; set; }
        public string CreatedBy { get; set; } = "Fahad";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
