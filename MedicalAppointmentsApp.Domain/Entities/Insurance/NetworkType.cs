using MedicalAppointmentsApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.Insurance
{
    [Table("NetworkType", Schema = "Insurance")]
    public class NetworkType : InsuranceBaseEntity
    {
        [Key]
        public int NetworkTypeId { get; set; }
        public string? Description { get; set; }
    }

}
