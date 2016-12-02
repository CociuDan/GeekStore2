using WareHouseInfrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageInterface
{
    public interface IStore<TEntity> where TEntity : IEntity
    {
        void SaveEntity(TEntity entity);
        TEntity GetEntity(int id);
        IEnumerable<TEntity> GetAll();
    }
}
