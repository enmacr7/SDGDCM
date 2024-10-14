using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.System
{
    public class Roles : SpecificBaseEntity
    {
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
    }

}
