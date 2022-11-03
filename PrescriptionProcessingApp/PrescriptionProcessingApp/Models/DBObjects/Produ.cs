using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class Produ
    {
        public Guid IdProdus { get; set; }
        public Guid IdTipProdus { get; set; }
        public string NumeProdus { get; set; } = null!;
        public string? SubstantaActiva { get; set; }
        public decimal PretUnitar { get; set; }
        public int Stoc { get; set; }
        public DateTime Bbd { get; set; }

        public virtual TipProdu IdTipProdusNavigation { get; set; } = null!;
    }
}
