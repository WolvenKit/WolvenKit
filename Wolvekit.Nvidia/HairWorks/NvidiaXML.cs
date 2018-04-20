using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wolvekit.Nvidia.HairWorks
{
    static class NvidiaXML
    {
        public static void AddNvValue(this XElement elem, string name, string type, string value,
            bool isnull = false, params XElement[] extraElements)
        {
            var typenode = isnull ? new List<XAttribute>(){new XAttribute("null",1),new XAttribute("type", type)} :
                new List<XAttribute>(){new XAttribute("type", type)};
            if (extraElements != null && extraElements.Length > 0)
            {
                elem.Add(new XElement("value",
                    new XAttribute("name",name),
                    typenode,
                    extraElements,
                    value));
            }
            else
            {
                elem.Add(new XElement("value",
                    new XAttribute("name",name),
                    typenode,
                    value));   
            }
        }

        public static XElement CreateStructHeader(string name, string type, string classname, string version,
            string checksum)
        {
            XElement ret = new XElement("value");
            ret.Add(new XAttribute("name",name));
            ret.Add(new XAttribute("type",type));
            ret.Add(new XAttribute("className",classname));
            ret.Add(new XAttribute("version",version));
            ret.Add(new XAttribute("checksum",checksum));
            return ret;
        }


    }
}
