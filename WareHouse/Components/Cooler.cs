using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class Cooler : Entity
    {
        public string Manufacturer { get; }
        public uint MaxTDP { get; }
        public string Model { get; }
        public string Socket { get; }


        public Cooler(string manufacturer, uint maxTDP, string model, string socket)
        {
            try
            {
                if (manufacturer == string.Empty || maxTDP == 0 || model == string.Empty || socket == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Manufacturer = manufacturer;
                    Model = model;
                    Socket = socket;
                    MaxTDP = maxTDP;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("You can't initialize an object with null values!");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(ex);
            }
        }

        public override string ToString()
        {
            var itemToString = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append("Cooler Specs:");
            sb.Append(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.Append(string.Format("\t MaxTDP: {0}", MaxTDP));
            sb.Append(string.Format("\t Model: {0}", Model));
            sb.Append(string.Format("\t Socket: {0}", Socket));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
