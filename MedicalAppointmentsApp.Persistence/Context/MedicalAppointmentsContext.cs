using Microsoft.EntityFrameworkCore;
using MedicalAppointmentsApp.Domain.Entities.Appointments;
using MedicalAppointmentsApp.Domain.Entities.Insurance;
using MedicalAppointmentsApp.Domain.Entities.Medical;
using MedicalAppointmentsApp.Domain.Entities.Security;
using MedicalAppointmentsApp.Domain.Entities.System;
using MedicalAppointmentsApp.Domain.Entities.Users;

namespace MedicalAppointmentsApp.Persistence.Context
{
    public partial class MedicalAppointmentsContext : DbContext
    {
        public MedicalAppointmentsContext(DbContextOptions<MedicalAppointmentsContext> options) : base(options)
        {
        }

        #region "Appointments Entities"
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<DoctorAvailability> DoctorsAvailability { get; set; }
        #endregion

        #region "Insurance Entities"
        public DbSet<InsuranceProviders> InsuranceProviders { get; set; }
        public DbSet<NetworkType> NetworkTypes { get; set; }
        #endregion

        #region "Medical Entities"
        public DbSet<AvailabilityModes> AvailabilityModes { get; set; }
        public DbSet<MedicalRecords> MedicalRecords { get; set; }
        public DbSet<Specialties> Specialties { get; set; }

        #endregion

        #region "Security Entities"
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
        #endregion

        #region "System Entities"
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Status> Status { get; set; }

        #endregion

        #region "Users Entities"
        public DbSet<Doctors> Doctors { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Users> Users { get; set; }

        #endregion
    }
}
