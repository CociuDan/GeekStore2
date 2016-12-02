namespace WareHouseInfrastructure
{
    public interface IIdGeneration<out TId>
    {
        TId NextId();
    }
}
