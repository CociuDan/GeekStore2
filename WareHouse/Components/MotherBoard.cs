using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Components
{
    public class MotherBoard : Entity
    {
        public string ChipSet { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public string RAMGeneration { get; }
        public string Socket { get; }

        public MotherBoard(string chipSet, string manufacturer, string model, string ramGeneration, string socket)
        {
            ChipSet = chipSet;
            Manufacturer = manufacturer;
            Model = model;
            RAMGeneration = ramGeneration;
            Socket = socket;
        }

        public override string ToString()
        {
            var itemToString = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("MotherBoard Specs:");
            sb.AppendLine(string.Format("\t ChipSet: {0}", ChipSet));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            sb.AppendLine(string.Format("\t RAMGeneration: {0}", RAMGeneration));
            sb.AppendLine(string.Format("\t Socket: {0}", Socket));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
