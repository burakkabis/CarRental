using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//NOT:Core katmani diger katmanlari referans almaz.Alirsa demek ki o katmana bagimliyiz demek.Northwinde bagimli olamayiz sadece yarin vs baska projede de kullanabilirm.(Car rental gibi.)

namespace Core.DataAccess
{
    public interface IEntitiyRepository<T> where T:class,IEntity,new()
    {

        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
