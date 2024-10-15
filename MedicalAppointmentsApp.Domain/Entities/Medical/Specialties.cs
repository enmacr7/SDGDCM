using MedicalAppointmentsApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.Medical
{
    [Table("Specialties", Schema = "medical")]

    public class Specialties : SpecificBaseEntity
    {
        [Key]
        public int SpecialtyID { get; set; }
        public string? SpecialtyName { get; set; }
    }

}
