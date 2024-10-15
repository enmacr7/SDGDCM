using MedicalAppointmentsApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.Medical
{
    [Table("AvailabilityModes", Schema = "medical")]

    public class AvailabilityModes : SpecificBaseEntity
    {
        [Key]
        public int SAvailabilityModeID { get; set; }
        public string? AvailabilityMode { get; set; }
    }

}
