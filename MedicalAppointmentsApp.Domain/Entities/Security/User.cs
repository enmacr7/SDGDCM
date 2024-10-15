namespace MedicalAppointmentsApp.Domain.Entities.Security
{
    public class User
    {
        public int IdUser { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
