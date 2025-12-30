using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atmosync.Shared.Models.DtoModels;

namespace Atmosync.Shared.Models.ViewModels
{
    public sealed class MQ136SensorViewModel : BaseModel
    {
        public long Id { get; set; }
        public int H2SLevel { get; set; }
    }
}
