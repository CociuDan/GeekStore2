using System;
using System.Collections.Generic;
using WareHouseInfrastructure;
using WareHouse;
using System.Linq;
using StorageInterface;
using WareHouse.Computers;

namespace DataAccess
{
    public abstract class DataAccess<TEntity> : IDataAccess<TEntity> where TEntity : IEntity
    {
        private IStore<TEntity> _store;

        protected DataAccess(IStore<TEntity> store)
        {
            _store = store;
        }

        public void SaveEntity(TEntity entity)
        {
            _store.SaveEntity(entity);
        }

        public IEnumerable<TEntity> Filter(Func<TEntity, bool> filter)
        {
            return _store.GetAll().Where(filter);
        }

        public TEntity GetById(int id)
        {
            return _store.GetEntity(id);
        }
    }
}
