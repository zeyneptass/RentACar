using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
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
