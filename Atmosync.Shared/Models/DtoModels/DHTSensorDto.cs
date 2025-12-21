using System.ComponentModel.DataAnnotations;

namespace Atmosync.Shared.Models.DtoModels
{
    public class DHTSensorDto : BaseModel
    {
        public long Id { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
    }
}
