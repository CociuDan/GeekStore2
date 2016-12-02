using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Peripherals
{
    public class Keyboard : Entity
    {
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }

        public Keyboard(string manufacturer, string model, string type)
        {
            try
            {
                if(manufacturer == string.Empty || model == string.Empty || type == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
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
            sb.AppendLine("Keyboard Specs:");
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Type: {0}", Type));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
