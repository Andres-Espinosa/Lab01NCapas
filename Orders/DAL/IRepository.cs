using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepository : IDisposable
    {
        //Agregar una nueva entidad a la base da datos
        Task<TEntity> CreateAsync<TEntity>(TEntity toCreate) where TEntity : class;

        // para eliminar una entidad
        Task<bool> DeleteAsync<TEntity>(TEntity toDelete) where TEntity : class;

        // para actualizar una entidad
        Task<bool> UpdateAsync<TEntity>(TEntity toUpdate) where TEntity : class;

        // para recuperar una entidad con base en un criterio

        Task<TEntity> RetreiveAsync<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;

        //para recuperar un conjunto de entidades con base en un criterio de busqueda

        Task<List<TEntity>> FilterAsync<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class;

    }
}
