using MedicalAppointmentsApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.System
{
    [Table("Roles", Schema = "system")]

    public class Roles : SpecificBaseEntity
    {
        [Key]
        public int RoleID { get; set; }
        public string? RoleName { get; set; }
    }

}
