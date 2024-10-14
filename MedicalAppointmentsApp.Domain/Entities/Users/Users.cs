using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Users
{
    public class Users : UsersBaseEntity
    {
        public int NetworkTypeId { get; set; }
        public string? Description { get; set; }
    }

}
