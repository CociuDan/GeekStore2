using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class PSU : Entity
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public uint Power { get; }

        public PSU(string manufacturer, string model, uint power)
        {
            try
            {
                if(manufacturer == string.Empty || model == string.Empty || power == 0)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Manufacturer = manufacturer;
                    Model = model;
                    Power = power;
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
            sb.AppendLine("PSU Specs:");
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Power: {0}", Power));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
