using StorageInterface;
using WareHouse;
using WareHouse.Computers;

namespace DataAccess
{
    public class DesktopPCDal : DataAccess<DesktopPC>
    {
        public DesktopPCDal(IStore<DesktopPC> store) : base(store)
        {
        }
    }
}
