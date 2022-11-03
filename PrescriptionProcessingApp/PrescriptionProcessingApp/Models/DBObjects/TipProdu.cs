using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class TipProdu
    {
        public TipProdu()
        {
            Produs = new HashSet<Produ>();
        }

        public Guid IdTipProdus { get; set; }
        public string Categorie { get; set; } = null!;
        public string? Detalii { get; set; }

        public virtual ICollection<Produ> Produs { get; set; }
    }
}
