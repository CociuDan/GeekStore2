using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class RAM : Entity
    {
        public uint Capacity { get; }
        public uint Frequency { get; }
        public string Generation { get; }
        public string Manufacturer { get; }
        public string Model { get; }

        public RAM(uint capacity, uint frequency, string generation, string manufacturer, string model)
        {
            try
            {
                if (capacity == 0 || frequency == 0 || generation == string.Empty || manufacturer == string.Empty || model == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Capacity = capacity;
                    Frequency = frequency;
                    Generation = generation;
                    Manufacturer = manufacturer;
                    Model = model;
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
            sb.AppendLine("RAM Specs:");
            sb.AppendLine(string.Format("\t Capacity: {0}", Capacity));
            sb.AppendLine(string.Format("\t Frequency: {0}", Frequency));
            sb.AppendLine(string.Format("\t Generation: {0}", Generation));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
