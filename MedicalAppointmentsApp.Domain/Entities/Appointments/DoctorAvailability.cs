﻿namespace MedicalAppointmentsApp.Domain.Entities.Appointments
{
    public class DoctorAvailability
    {
        public int AvailabilityID { get; set; }
        public int DoctorID { get; set; }
        public DateTime AvailableDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }

}
