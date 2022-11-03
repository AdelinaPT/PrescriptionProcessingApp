using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class Produs
    {
        public Guid IdProdus { get; set; }
        public Guid IdTipProdus { get; set; }
        public string NumeProdus { get; set; } = null!;
        public string? SubstantaActiva { get; set; }
        public decimal PretUnitar { get; set; }
        public int Stoc { get; set; }
        public DateTime Bbd { get; set; }

        public virtual TipProdus IdTipProdusNavigation { get; set; } = null!;
    }
}
