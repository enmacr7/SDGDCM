using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Medical
{
    public class MedicalRecords : BaseEntity
    {
        public int RecordID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public string? Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public DateTime DateOfVisit { get; set; }
    }

}
