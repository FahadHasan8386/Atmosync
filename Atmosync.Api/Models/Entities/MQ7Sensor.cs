namespace Atmosync.Api.Models.Entities
{
    public class MQ7Sensor
    {
        public long Id { get; set; }
        public  int COLevel { get; set; }
        public string CreatedBy { get; set; } = "Fahad";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
