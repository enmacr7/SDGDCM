using MedicalAppointmentsApp.Domain.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MedicalAppointmentsApp.Domain.Entities.Users
{
    [Table("Users", Schema = "users")]

    public class Users : UsersBaseEntity
    {
        [Key]
        public int NetworkTypeId { get; set; }
        public string? Description { get; set; }
    }

}
