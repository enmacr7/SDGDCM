using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Medical
{
    public class AvailabilityModes : SpecificBaseEntity
    {
        public int SAvailabilityModeID { get; set; }
        public string? AvailabilityMode { get; set; }
    }

}
