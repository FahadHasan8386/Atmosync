namespace Atmosync.Shared.Models.DtoModels
{
    public class BaseModel
    {
        public string CreatedBy { get; set; } = "Fahad";
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool InActive { get; set; } = false;
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
