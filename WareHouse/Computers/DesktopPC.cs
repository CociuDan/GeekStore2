using WareHouse.Components;
using WareHouse.Peripherals;
using WareHouseInfrastructure;
using System;
using System.Text;

namespace WareHouse.Computers
{
    public class DesktopPC : Entity
    {
        public Case Case { get; private set; }
        public Cooler Cooler { get; private set; }
        public CPU CPU { get; private set; }
        public GPU GPU { get; private set; }
        public HDD HDD { get; private set; }
        public Keyboard Keyboard { get; private set; }
        public Monitor Monitor { get; private set; }
        public MotherBoard MotherBoard { get; private set; }
        public Mouse Mouse { get; private set; }
        public PSU PSU { get; private set; }
        public RAM RAM { get; private set; }

        public DesktopPC(Case pcCase, Cooler cooler, CPU cpu, GPU gpu, HDD hdd, Keyboard keyboard, Monitor monitor, MotherBoard motherBoard, Mouse mouse, PSU psu, RAM ram)
        {
            Case = pcCase;
            Cooler = cooler;
            CPU = cpu;
            GPU = gpu;
            HDD = hdd;
            Keyboard = keyboard;
            Monitor = monitor;
            MotherBoard = motherBoard;
            Mouse = mouse;
            PSU = psu;
            RAM = ram;
        }

        public override string ToString()
        {
            var itemToString = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.Append("Desktop PC Specs:");
            sb.Append(string.Format("\t {0}", Case.ToString()));
            sb.Append(string.Format("\t {0}", Cooler.ToString()));
            sb.Append(string.Format("\t {0}", CPU.ToString()));
            sb.Append(string.Format("\t {0}", GPU.ToString()));
            sb.Append(string.Format("\t {0}", HDD.ToString()));
            sb.Append(string.Format("\t {0}", Keyboard.ToString()));
            sb.Append(string.Format("\t {0}", Monitor.ToString()));
            sb.Append(string.Format("\t {0}", MotherBoard.ToString()));
            sb.Append(string.Format("\t {0}", Mouse.ToString()));
            sb.Append(string.Format("\t {0}", PSU.ToString()));
            sb.Append(string.Format("\t {0}", RAM.ToString()));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
