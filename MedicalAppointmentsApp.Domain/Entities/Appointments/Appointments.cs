using MedicalAppointmentsApp.Domain.Base;

namespace MedicalAppointmentsApp.Domain.Entities.Appointments
{
    public class Appointments : BaseEntity
    {
        public int AppointmentID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public int StatusID { get; set; }
    }

}
