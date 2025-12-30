using Atmosync.Shared.Models.DtoModels;

namespace Atmosync.Shared.Models.ViewModels
{
    public sealed class DHTSensorViewModel : BaseModel
    {
        public long Id { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }

    }
}
