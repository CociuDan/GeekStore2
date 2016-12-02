using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class HDD : Entity
    {
        public uint Capacity { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public uint ReadSpeed { get; }
        public uint RPM { get; }
        public string Type { get; }
        public uint WriteSpeed { get; }

        public HDD(uint capacity, string manufacturer, string model, uint readSpeed, uint rpm, string type, uint writeSpeed)
        {
            try
            {
                if(capacity == 0 || manufacturer == string.Empty || model == string.Empty || readSpeed == 0 || rpm == 0 || type == string.Empty || writeSpeed == 0)
                {
                    Console.WriteLine("You can't initialize an object with empty values!");
                }
                else
                {
                    Capacity = capacity;
                    Manufacturer = manufacturer;
                    Model = model;
                    ReadSpeed = readSpeed;
                    RPM = rpm;
                    Type = type;
                    WriteSpeed = writeSpeed;
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
            sb.AppendLine("HDD Specs:");
            sb.AppendLine(string.Format("\t Capacity: {0}", Capacity));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t ReadSpeed: {0}", ReadSpeed));
            sb.AppendLine(string.Format("\t RPM: {0}", RPM));
            sb.AppendLine(string.Format("\t Type: {0}", Type));
            sb.AppendLine(string.Format("\t WriteSpeed: {0}", WriteSpeed));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
