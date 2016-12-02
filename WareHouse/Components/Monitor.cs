using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class Monitor : Entity
    {
        public uint Frequency { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string Resolution { get; }
        public double ScreenSize { get; }

        public Monitor(uint frequency, string manufacturer, string model, string resolution, double screenSize)
        {
            try
            {
                if(frequency == 0 || manufacturer == string.Empty || model == string.Empty || resolution == string.Empty || screenSize == 0.0 || screenSize < 0)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Frequency = frequency;
                    Manufacturer = manufacturer;
                    Model = model;
                    Resolution = resolution;
                    ScreenSize = screenSize;
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
            sb.AppendLine("Monitor Specs:");
            sb.AppendLine(string.Format("\t Frequency: {0}", Frequency));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Resolution: {0}", Resolution));
            sb.AppendLine(string.Format("\t ScreenSize: {0}", ScreenSize));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
