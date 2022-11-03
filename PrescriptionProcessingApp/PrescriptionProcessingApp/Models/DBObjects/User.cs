using System;
using System.Collections.Generic;

namespace PrescriptionProcessingApp.Models.DBObjects
{
    public partial class User
    {
        public User()
        {
            Reteta = new HashSet<Reteta>();
        }

        public Guid IdUser { get; set; }
        public Guid IdUserType { get; set; }
        public string UserName { get; set; } = null!;

        public virtual UserType IdUserTypeNavigation { get; set; } = null!;
        public virtual ICollection<Reteta> Reteta { get; set; }
    }
}
