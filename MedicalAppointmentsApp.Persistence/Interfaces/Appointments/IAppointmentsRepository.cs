using MedicalAppointmentsApp.Domain.Repositories;
using MedicalAppointmentsApp.Domain.Entities.Appointments;

namespace MedicalAppointmentsApp.Persistence.Interfaces.Appointments
{
    public interface IAppointmentsRepository : IBaseRepository<Appointments>
    {
    }
}
