using System.ComponentModel.DataAnnotations;

namespace Atmosync.Shared.Models.DtoModels
{
    public class MQ7SensorDto : BaseModel
    {
        public long Id { get; set; }
        public int COLevel { get; set; }

    }
}
