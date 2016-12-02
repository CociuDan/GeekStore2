using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class GPU : Entity
    {
        public string Architecture { get; }
        public uint BandWidth { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public uint VRAM { get; }

        public GPU(string architecture, uint bandWidth, string manufacturer, string model, uint vram)
        {
            try
            {
                if(architecture == string.Empty || bandWidth == 0 || manufacturer == string.Empty || model == string.Empty || vram == 0)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Architecture = architecture;
                    BandWidth = bandWidth;
                    Manufacturer = manufacturer;
                    Model = model;
                    VRAM = vram;
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
            sb.AppendLine("GPU Specs:");
            sb.AppendLine(string.Format("\t Architecture: {0}", Architecture));
            sb.AppendLine(string.Format("\t BandWidth: {0}", BandWidth));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t VRAM: {0}", VRAM));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
