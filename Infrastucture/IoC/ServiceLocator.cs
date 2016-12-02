using StorageInterface;
using Ninject;
using WareHouseInfrastructure;
using StorageImplimentation;

namespace Infrastucture.IoC
{
    public static class ServiceLocator
    {
        private static readonly IKernel Kernel = new StandardKernel();

        public static void RegisterAll()
        {
            Kernel.Bind(typeof(IIdGeneration<>)).To<SimpleIdGeneration>();
            Kernel.Bind(typeof(IStore<>)).To(typeof(ListStore<>));
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}
