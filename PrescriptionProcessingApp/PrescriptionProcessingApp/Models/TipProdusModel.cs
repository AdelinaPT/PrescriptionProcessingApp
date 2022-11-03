namespace PrescriptionProcessingApp.Models
{
    public class TipProdusModel
    {
        public Guid IdTipProdus { get; set; }
        public string Categorie { get; set; } = null!;
        public string? Detalii { get; set; }
    }
}
