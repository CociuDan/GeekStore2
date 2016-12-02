using WareHouseInfrastructure;
using System;
using System.Collections.Generic;

namespace DataAccess
{
    public interface IDataAccess<TEntity> where TEntity : IEntity
    {
        TEntity GetById(int id);

        IEnumerable<TEntity> Filter(Func<TEntity, bool> filter);
    }
}
