using System.Collections.Generic;
using WareHouseInfrastructure;
using System.Linq;
using StorageInterface;

namespace StorageImplimentation
{
    public class ListStore<TEntity> : IStore<TEntity> where TEntity : IEntity
    {
        private readonly IList<TEntity> _data;
        private readonly IIdGeneration<int> _idGeneration;

        public ListStore(IIdGeneration<int> idGeneration)
        {
            _idGeneration = idGeneration;
            _data = new List<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _data;
        }

        public TEntity GetEntity(int id)
        {
            return _data.Where(x => x.ID == id).First();
        }

        public void SaveEntity(TEntity entity)
        {
            _data.Add(entity);
        }
    }
}
