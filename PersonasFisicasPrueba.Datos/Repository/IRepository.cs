using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace PersonasFisicasPrueba.Datos.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null);

        T Get(int id);
        void Add(T registro);
        void Remove(T registro);
        void Remove(int id);

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);
    }
}
