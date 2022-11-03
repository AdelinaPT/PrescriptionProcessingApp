using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class TipProdus
    {
        public TipProdus()
        {
            Produs = new HashSet<Produs>();
        }

        public Guid IdTipProdus { get; set; }
        public string Categorie { get; set; } = null!;
        public string? Detalii { get; set; }

        public virtual ICollection<Produs> Produs { get; set; }
    }
}
