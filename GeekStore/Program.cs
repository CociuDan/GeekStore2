using DataAccess;
using WareHouseInfrastructure;
using WareHouse;
using Infrastucture.IoC;
using WareHouse.Computers;
using WareHouse.Components;
using WareHouse.Peripherals;
using System;

namespace GeekStore
{
    class Program
    {
        private static DesktopPCDal _desktopDal;
        static Program()
        {
            ServiceLocator.RegisterAll();
            _desktopDal = ServiceLocator.Get<DesktopPCDal>();
        }
        static void Main(string[] args)
        {
            var pc = new DesktopPC(
                new Case("Mid Tower", "DELL", "Optiplex 790"),
                new Cooler("Deepcool", 95, "Gammaxx 200", "LGA1156/LGA1155/LGA1151/LGA1150/LGA775/FM2/FM1/AM3+/AM3/AM2+/AM2/940/939/754"),
                new CPU("Sandy Bridge", 3.40, 3.80, 4, "Intel", "i7 2600", 8, 95),
                new GPU("Maxwell", 128, "MSI", "GTX 750 Ti OC", 2048),
                new HDD(240, "Crucial", "BX100", 550, 0, "SSD", 530),
                new Keyboard("Logitech", "EX110", "Mechanical"),
                new Monitor(60, "LG", "24MN43", "1920x1080", 23.6),
                new MotherBoard("Intel Q65 Express", "DELL", "Dell Optiplex 790 Q65", "DDR3", "LGA1155"),
                new Mouse(2500, "Logitech", "G100S", "Optical"),
                new PSU("SuperPower", "SuperPower 550", 550),
                new RAM(4096, 1333, "DDR3", "Samsung", "Samsung PC3-10600 1333 2 GB")
                );
            _desktopDal.SaveEntity(pc);
            var ceva = _desktopDal.GetById(0);
            Console.WriteLine(ceva);
            Console.ReadKey();






            //List<IItems> availableComponents = new List<IItems>();
            //availableComponents.Add(new CPU("Sandy Bridge", 3.40, 3.80, 4, "Intel", "i7 2600", 8, 95));
            //availableComponents.Add(new Cooler("Deepcool", 95, "Gammaxx 200", "LGA1156/LGA1155/LGA1151/LGA1150/LGA775/FM2/FM1/AM3+/AM3/AM2+/AM2/940/939/754"));
            //availableComponents.Add(new GPU("Maxwell", 128, "MSI", "GTX 750 Ti OC", 2048));
            //availableComponents.Add(new RAM(4096, 1333, "DDR3", "Samsung", "Samsung PC3-10600 1333 2 GB"));
            //availableComponents.Add(new HDD(240, "Crucial", "BX100", 550, 0, "SSD", 530));
            //availableComponents.Add(new MotherBoard("Intel Q65 Express", "DELL", "Dell Optiplex 790 Q65", "DDR3", "LGA1155"));
            //availableComponents.Add(new Case("Mid Tower", "DELL", "Optiplex 790"));
            //availableComponents.Add(new PSU("SuperPower", "SuperPower 550", 550));
            //availableComponents.Add(new Monitor(60, "LG", "24MN43", "1920x1080", 23.6));
            //availableComponents.Add(new Headphones(16, "Philips", "A5 Pro", "Over The Ear"));
            //availableComponents.Add(new Keyboard("Logitech", "EX110", "Mechanical"));
            //availableComponents.Add(new Mouse(2500, "Logitech", "G100S", "Optical"));
            //availableComponents.Add(new Speakers("Edifier", "X500", 24));
            //foreach(var item in availableComponents)
            //{
            //    item.ShowItemSpecs();
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            //Case ceva = new Case("Mid Tower", "DELL", "Optiplex 790");
            //Console.WriteLine(JsonConvert.SerializeObject(ceva));
            ////ceva.ID = 0;
            //DesktopPC pc = new DesktopPC(
            //    new Case("Mid Tower", "DELL", "Optiplex 790"),
            //    new Cooler("Deepcool", 95, "Gammaxx 200", "LGA1156/LGA1155/LGA1151/LGA1150/LGA775/FM2/FM1/AM3+/AM3/AM2+/AM2/940/939/754"),
            //    new CPU("Sandy Bridge", 3.40, 3.80, 4, "Intel", "i7 2600", 8, 95),
            //    new GPU("Maxwell", 128, "MSI", "GTX 750 Ti OC", 2048),
            //    new HDD(240, "Crucial", "BX100", 550, 0, "SSD", 530),
            //    new Keyboard("Logitech", "EX110", "Mechanical"),
            //    new Monitor(60, "LG", "24MN43", "1920x1080", 23.6),
            //    new MotherBoard("Intel Q65 Express", "DELL", "Dell Optiplex 790 Q65", "DDR3", "LGA1155"),
            //    new Mouse(2500, "Logitech", "G100S", "Optical"),
            //    new PSU("SuperPower", "SuperPower 550", 550),
            //    new RAM(4096, 1333, "DDR3", "Samsung", "Samsung PC3-10600 1333 2 GB")
            //    );
            //pc.Case.ToString();
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine();
            ////pc.Case = new Case("Full Tower", "Corsair", "780T");
            //pc.Case.ToString();
            //Console.ReadKey();

            //WareHouse wh = new WareHouse();
            //CPU cpu = new CPU("Sandy Bridge", 3.4, 3.8, 4, "Intel", "i7 2600", 8, 95);
            //wh.SaveItem(cpu);
            //wh.AddItemToWareHouse(cpu);
            //wh.ShowItemsAvailable();
        }
    }
}
