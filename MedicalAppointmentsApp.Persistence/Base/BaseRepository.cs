using MedicalAppointmentsApp.Domain.Repositories;
using MedicalAppointmentsApp.Domain.Result;
using MedicalAppointmentsApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MedicalAppointmentsApp.Persistence.Base
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly MedicalAppointmentsContext _medicalAppointmentsContext;
        private DbSet<TEntity> entities;

        public BaseRepository(MedicalAppointmentsContext medicalAppointmentsContext) 
        {
            _medicalAppointmentsContext = medicalAppointmentsContext;
            this.entities = _medicalAppointmentsContext.Set<TEntity>();
        }
        public virtual async Task<OperationResult> Exists(Expression<Func<TEntity, bool>> filter)
        {
            OperationResult result = new OperationResult();

            try
            {
                var exists = await this.entities.AnyAsync(filter);
                result.Data = exists;
            }
            catch(Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} verificando que existe el registro";
            }

            return result;
        }

        public virtual async Task<OperationResult> GetAll()
        {
            OperationResult result = new OperationResult();

            try
            {
                var AllData = await this.entities.ToListAsync();
                result.Data = AllData;
            }
            catch(Exception ex) 
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} obteniendo los datos";
            }

            return result;
        }

        public virtual async Task<OperationResult> GetEntitBy(int Id)
        {
            OperationResult result = new OperationResult();

            try
            {
                var entity = await this.entities.FindAsync(Id);
                result.Data = entity;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} obteniendo la entidad";
            }

            return result;
        }

        public async virtual Task<OperationResult> Remove(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Remove(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} removiendo los datos";
            }

            return result;
        }

        public virtual async Task<OperationResult> Save(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Add(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} guardando los datos";
            }

            return result;
        }

        public virtual async Task<OperationResult> Update(TEntity entity)
        {
            OperationResult result = new OperationResult();

            try
            {
                entities.Update(entity);
                await _medicalAppointmentsContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"Ocurrio un error {ex.Message} actualizando los datos";
            }

            return result;
        }
    }
}
