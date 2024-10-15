using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.System
{
    [Table("Status", Schema = "system")]

    public class Status
    {
        [Key]
        public int StatusID { get; set; }
        public string? StatusName { get; set; }
    }
}
