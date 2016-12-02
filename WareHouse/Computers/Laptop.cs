using WareHouse.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Computers
{
    public class Laptop
    {
        public CPU CPU { get; }
        public GPU GPU { get; }
        public HDD HDD { get; }
        public string Manufacturer { get; }
        public string Model { get; }
        public Monitor Monitor { get; }
        public MotherBoard MotherBoard { get; }
        public RAM RAM { get; }

        public Laptop(CPU cpu, GPU gpu, string manufacturer, string model, Monitor monitor, MotherBoard motherBoard, RAM ram)
        {
            CPU = cpu;
            GPU = gpu;
            Manufacturer = manufacturer;
            Model = model;
            Monitor = monitor;
            MotherBoard = motherBoard;
            RAM = ram;
        }

        public void ShowComputerSpecs()
        {
            StringBuilder manufAndModel = new StringBuilder();
            manufAndModel.Append(Manufacturer);
            manufAndModel.Append(" ");
            manufAndModel.Append(Model);
            manufAndModel.Append(" Specs:");
            Console.WriteLine(manufAndModel);
            CPU.ToString();
            GPU.ToString();
            HDD.ToString();
            Monitor.ToString();
            MotherBoard.ToString();
            RAM.ToString();
        }
    }
}
