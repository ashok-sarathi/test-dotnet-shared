using App.Data;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.Helpers.Common
{
    public interface ICommonService<TModel, TReadModel, TQueryModel>
    {
        IList<TReadModel> Get(TQueryModel query);
        TModel GetById(Guid id);
        TModel Create(TModel model);
        TModel Update(TModel model);
        void Delete(Guid id);
    }
    public abstract class CommonService<TEntity, TModel, TReadModel, TQueryModel>(AppDbContext context, IMapper mapper)
        : ICommonService<TModel, TReadModel, TQueryModel>
        where TEntity : class
    {
        public abstract IList<TReadModel> Get(TQueryModel query);

        public TModel GetById(Guid id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            return mapper.Map<TModel>(entity);
        }

        public TModel Create(TModel model)
        {
            TEntity entity = mapper.Map<TEntity>(model);

            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
            return mapper.Map<TModel>(entity);
        }

        public TModel Update(TModel model)
        {
            TEntity entity = mapper.Map<TEntity>(model);
            context.Set<TEntity>().Update(entity);
            context.SaveChanges();
            return mapper.Map<TModel>(entity);
        }

        public void Delete(Guid id)
        {
            TEntity entity = context.Set<TEntity>().Find(id);
            context.Remove(entity);
            context.SaveChanges();
        }
    }
}
