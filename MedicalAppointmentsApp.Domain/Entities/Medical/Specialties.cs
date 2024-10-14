using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Medical
{
    public class Specialties : SpecificBaseEntity
    {
        public int SpecialtyID { get; set; }
        public string? SpecialtyName { get; set; }
    }

}
