using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml;

namespace Seminar09
{
    public class Json2XML
    {
        private string str;

        public Json2XML(string _str)
        {
            this.str = _str;
        }
        public void Use()
        {
            var json = JsonDocument.Parse(str);

            var xml = new XmlDocument();
            var xmlRoot = xml.CreateElement("root");
            xml.AppendChild(xmlRoot);
            ConvertJson2Xml(json.RootElement, xmlRoot);
            Console.WriteLine(xml.OuterXml);
        }
        static void ConvertJson2Xml(JsonElement jsonElement, XmlElement xmlParent)
        {
            foreach (var prop in jsonElement.EnumerateObject())
            {
                if (prop.Value.ValueKind == JsonValueKind.Object)
                {
                    var xmlElement = xmlParent.OwnerDocument.CreateElement(prop.Name);
                    xmlParent.AppendChild(xmlElement);
                    ConvertJson2Xml(prop.Value, xmlElement);
                }
                else
                {
                    var xmlElement = xmlParent.OwnerDocument.CreateElement(prop.Name);
                    xmlElement.InnerText = prop.Value.ToString();
                    xmlParent.AppendChild(xmlElement);
                }
            }
        }
    }
}
