namespace Atmosync.Api.Models.DtoModels
{
    public class DHTSensorDto : BaseModel
    {
        public long Id { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}
