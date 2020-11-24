using System;
using System.Xml;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Uitlezen van XML...
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(@"test2.xml");
            var rootElement = xmlDoc.DocumentElement;
            var items = rootElement.GetElementsByTagName("user");
 
            foreach (XmlNode node in items)
            {
                Console.WriteLine(node.InnerText);
                /*
                    if (node.FirstChild.Attributes != null)
                    {
                        Console.WriteLine(node.FirstChild.Attributes["first_name"].Value);
                        Console.WriteLine(node.FirstChild.Value);
                    }
                */
            }

            // Uitlezen van JSON...
            /*
            var jsonString = File.ReadAllText("test2.json");
            JObject o1 = JObject.Parse(File.ReadAllText(@"c:\videogames.json"));

            using (System.IO.StreamReader file = File.OpenText(@"c:\videogames.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
            }
            */

            // Uitlezen van TXT...
            // Zie eerdere lessen...
        }
    }

    public class User
    {
        public int id;
        public string first_name;
        public string last_name;
        public string email;
        public string gender;
        public string ip_address;
    }
}
