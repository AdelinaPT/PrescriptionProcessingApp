namespace PrescriptionProcessingApp.Models
{
    public class RetetaModel
    {
        public Guid IdReteta { get; set; }
        public string? SerieNumar { get; set; }
        public Guid IdUser { get; set; }
        public string Status { get; set; } = null!;
    }
}
