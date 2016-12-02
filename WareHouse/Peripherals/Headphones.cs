using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Peripherals
{
    public class Headphones : Entity
    {
        public uint Impedance { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }

        public Headphones(uint impedance, string manufacturer, string model, string type)
        {
            try
            {
                if (impedance == 0 || manufacturer == string.Empty || model == string.Empty || type == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Impedance = impedance;
                    Manufacturer = manufacturer;
                    Model = model;
                    Type = type;
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
            sb.AppendLine("Headphones Specs:");
            sb.AppendLine(string.Format("\t Impedance: {0}", Impedance));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Type: {0}", Type));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
