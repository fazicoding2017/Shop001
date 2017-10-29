﻿using HomeAccessories.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HomeAccessories.DataAccess.Abstract
{
  public interface IEntityRepository<T> where T : class, IEntity, new()
  {
    T Get(Expression<Func<T, bool>> filter);

    List<T> GetList(Expression<Func<T, bool>> filter = null,
        Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        int? page = null, int? pageSize = null);

    void Add(T entity);

    void Update(T entity);

    void Delete(T entity);
  }
}
