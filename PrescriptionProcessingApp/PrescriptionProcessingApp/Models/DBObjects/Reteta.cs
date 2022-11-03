using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class Reteta
    {
        public Guid IdReteta { get; set; }
        public string? SerieNumar { get; set; }
        public Guid IdUser { get; set; }
        public string Status { get; set; } = null!;

        public virtual User IdUserNavigation { get; set; } = null!;
    }
}
