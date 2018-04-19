using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wolvekit.Nvidia.HairWorks
{
    class NvHairAssetHeaderInfo
    {
        private string fileVersion = "1.0";
        private string toolVersion = "WolvenKit " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        private string sourcePath = "https://github.com/Traderain/Wolven-kit";
        private string authorName = "WolvenKit";
        private string lastModified = DateTime.Now.ToString("f");

        private string checksum = "0xd225a2e5, 0x1295b170, 0x7b7dfeef, 0x07230aea";

        public NvHairAssetHeaderInfo()
        {

        }

        public XElement serialize(int objectcount)
        {
            var HairWorksInfo = new XElement("value");
            HairWorksInfo.Add(new XAttribute("name", ""));
            HairWorksInfo.Add(new XAttribute("type", "Ref"));
            HairWorksInfo.Add(new XAttribute("className", "HairWorksInfo"));
            HairWorksInfo.Add(new XAttribute("version", 1.1));
            HairWorksInfo.Add(new XAttribute("checksum", checksum));
            var values = new XElement("struct", new XAttribute("name", ""));
            values.Add(new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"), "1.1"));
            values.Add(new XElement("value", new XAttribute("name", "toolVersion"), new XAttribute("type", "String"),
                "WolvenKit"));
            values.Add(new XElement("value", new XAttribute("name", "sourcePath"), new XAttribute("type", "String"),
                "https://github.com/Traderain/Wolven-kit"));
            values.Add(new XElement("value", new XAttribute("name", "authorName"), new XAttribute("type", "String"),
                Environment.UserName));
            values.Add(new XElement("value", new XAttribute("name", "fileVersion"), new XAttribute("type", "String"),
                DateTime.Now.ToString("R")));
            HairWorksInfo.Add(values);
            return HairWorksInfo;
        }
    }
}
