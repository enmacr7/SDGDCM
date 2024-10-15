using MedicalAppointmentsApp.Domain.Entities.Appointments;
using MedicalAppointmentsApp.Persistence.Base;
using MedicalAppointmentsApp.Persistence.Context;
//using MedicalAppointmentsApp.Persistence.Interfaces.Appointments.IAppointmentsRepository;

namespace MedicalAppointmentsApp.Persistence.Repositories
{
    public class AppointmentsRepository : BaseRepository<Appointments>, IAppointmentsRepository
    {
        public AppointmentsRepository(MedicalAppointmentsContext medicalAppointmentsContext) : base(medicalAppointmentsContext);
    }

    public override Task<OperationResult> Update(Appointments entity)
    {
        return base.Update(entity);
    }
}
