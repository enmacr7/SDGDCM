using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Insurance
{
    public class NetworkType : InsuranceBaseEntity
    {
        public int NetworkTypeId { get; set; }
        public string? Description { get; set; }
    }

}
