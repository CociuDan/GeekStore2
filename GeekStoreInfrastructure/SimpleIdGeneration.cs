namespace WareHouseInfrastructure
{
    public class SimpleIdGeneration : IIdGeneration<int>
    {
        private static int _id = 1;

        public int NextId()
        {
            return _id++;
        }
    }
}
