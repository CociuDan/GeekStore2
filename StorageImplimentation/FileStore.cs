using System;
using System.Collections.Generic;
using WareHouseInfrastructure;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Xml;
using StorageInterface;

namespace StorageImplimentation
{
    public class FileStore<TEntity> : IStore<TEntity> where TEntity : IEntity
    {
        private XmlSerializer _serializer = new XmlSerializer(typeof(TEntity));
        XmlDocument xml = new XmlDocument();

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetEntity(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveEntity(TEntity entity)
        {
            var entityJson = JsonConvert.SerializeObject(entity);
            xml = JsonConvert.DeserializeXmlNode(entityJson);
            xml.Save(@"F:test.xml");
        }
    }
}
