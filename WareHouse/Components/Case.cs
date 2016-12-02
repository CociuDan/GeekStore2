using WareHouseInfrastructure;
using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WareHouse.Components
{
    public class Case : Entity
    {
        public string FormFactor { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Case(string formFactor, string manufacturer, string model)
        {
            try
            {
                if(formFactor == string.Empty || manufacturer == string.Empty || model == string.Empty)
                {
                    Console.WriteLine("You can't initialize an object with empty values! ");
                }
                else
                {
                    FormFactor = formFactor;
                    Manufacturer = manufacturer;
                    Model = model;
                }
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("You can't initialize an object with null values!");
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(ex);
            }
        }

        public override string ToString()
        {
            var itemToString = string.Empty;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Case Specs:");
            sb.AppendLine(string.Format("\t Form Factor: {0}", FormFactor));
            sb.AppendLine(string.Format("\t Manufacturer: {0}", Manufacturer));
            sb.AppendLine(string.Format("\t Model: {0}", Model));
            itemToString = sb.ToString();
            return itemToString;
        }
    }
}
