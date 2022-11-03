namespace PrescriptionProcessingApp.Models
{
    public class UserModel
    {
        public Guid IdUser { get; set; }
        public Guid IdUserType { get; set; }
        public string UserName { get; set; } = null!;
    }
}
