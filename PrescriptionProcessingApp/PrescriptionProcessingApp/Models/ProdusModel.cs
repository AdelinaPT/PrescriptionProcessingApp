using System.ComponentModel.DataAnnotations;

namespace PrescriptionProcessingApp.Models
{
    public class ProdusModel
    {
        public Guid IdProdus { get; set; }
        public Guid IdTipProdus { get; set; }
        public string NumeProdus { get; set; } = null!;
        public string? SubstantaActiva { get; set; }
        public decimal PretUnitar { get; set; }
        public int Stoc { get; set; }

        [DisplayFormat(DataFormatString = "0:MM/dd/yyyy")]
        [DataType(DataType.Date)]
        public DateTime Bbd { get; set; }
    }
}
