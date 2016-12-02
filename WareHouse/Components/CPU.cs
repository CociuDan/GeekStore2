using System;
using WareHouseInfrastructure;
using System.Text;

namespace WareHouse.Components
{
    public class CPU : Entity
    {
        
        public string Architecture { get; set; }
        public double BaseFrequency { get; }
        public double BoostFrequency { get; }
        public uint Cores { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public uint Threads { get; }
        public uint TDP { get; }

        public CPU()
        {

        }

        public CPU(string architecture, double baseFrequency, double boostFrequency, uint cores, string manufacturer, string model, uint threads, uint tdp)
        {
            try
            {
                if(architecture == string.Empty || baseFrequency == 0.0 || baseFrequency < 0 || boostFrequency == 0.0 || 
                   boostFrequency < 0 || cores == 0 || manufacturer == string.Empty || model == string.Empty || threads == 0 || tdp == 0)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Architecture = architecture;
                    BaseFrequency = baseFrequency;
                    BoostFrequency = boostFrequency;
                    Cores = cores;
                    Manufacturer = manufacturer;
                    Model = model;
                    Threads = threads;
                    TDP = tdp;
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
            sb.AppendLine("CPU Specs:");
            sb.AppendLine(string.Format("\t Architecture: {0}", Architecture));
            sb.AppendLine(string.Format("\t BaseFrequency: {0}", BaseFrequency));
            sb.AppendLine(string.Format("\t BoostFrequency: {0}", BoostFrequency));
            sb.AppendLine(string.Format("\t Cores: {0}", Cores));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t Threads: {0}", Threads));
            sb.AppendLine(string.Format("\t TDP: {0}", TDP));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
