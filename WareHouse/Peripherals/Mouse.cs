using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Peripherals
{
    public class Mouse : Entity
    {
        public uint DPI { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Type { get; }

        public Mouse(uint dpi, string manufacturer, string model, string type)
        {
            try
            {
                if(dpi == 0 || manufacturer == string.Empty || model == string.Empty || type == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    DPI = dpi;
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
            sb.Append("Mouse Specs:");
            sb.AppendLine(string.Format("\t DPI: {0}", DPI));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Type: {0}", Type));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
