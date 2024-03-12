using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filtre zorunlu değil
        T Get(Expression<Func<T, bool>> filter);  // tek bir elemanı getiren kod, filtre zorunlu
        void Add(T entitiy);
        void Update(T entitiy);
        void Delete(T entitiy);
    }
}
