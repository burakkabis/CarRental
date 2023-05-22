using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{

    //EntityFramewirk icin evrensel kod yaziyrouz.
    //Burada entityframework kodu yazacagiz.
    //Core u bir kere yazariz.Diger tum projelerimizde kullanabiliriz.
    //IEntity i yazamasin diye new ledik
    //IENTITY BU BIR VERITABANI TABLOSU DEMEK
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntitiyRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())

            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {

            using (TContext context = new TContext())

            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        //Tek bir data getirecek.

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {

            using (TContext context = new TContext())

            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            using (TContext context = new TContext())

            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();


            }
        }

        public void Update(TEntity entity)
        {

            using (TContext context = new TContext())

            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
