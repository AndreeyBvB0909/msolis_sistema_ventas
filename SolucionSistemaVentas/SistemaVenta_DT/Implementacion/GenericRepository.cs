using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaVenta.DT.DBContext;
using SistemaVenta.DT.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace SistemaVenta.DT.Implementacion
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly DBVENTAContext dbContext;

        public GenericRepository(DBVENTAContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public Task<TEntity> Obtener(Expression<Func<TEntity, bool>> filtro)
        {
            throw new NotImplementedException();
        }
        public Task<TEntity> Crear(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Editar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(TEntity entity)
        {
            throw new NotImplementedException();
        }
        public Task<IQueryable<TEntity>> Consultar(Expression<Func<TEntity, bool>> filtro = null)
        {
            throw new NotImplementedException();
        }
    }
}
