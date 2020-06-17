using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace Wolvekit.Nvidia.HairWorks
{
    class NvHairAssetHeaderInfo
    {
        private string fileVersion = "1.0";
        private string toolVersion = "WolvenKit " + 
                        FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
        private string authorName = "WolvenKit";

        private string checksum = "0xd225a2e5, 0x1295b170, 0x7b7dfeef, 0x07230aea";

        /// <summary>
        /// Default Ctor
        /// </summary>
        public NvHairAssetHeaderInfo() { }

        /// <summary>
        /// Creates an XElement suitable for seralizing it in a apx file.
        /// </summary>
        /// <param name="objectcount"></param>
        /// <returns></returns>
        public XElement serialize(CFurMeshResource apexChunk,int objectcount)
        {
            var HairWorksInfo = NvidiaXML.CreateStructHeader("", "Ref", "HairWorksInfo", "1.0", checksum);
            var values = new XElement("struct", new XAttribute("name", ""));
            values.AddNvValue("fileVersion", "String", "1.0");
            values.AddNvValue("toolVersion","String","WolvenKit");
            values.AddNvValue("sourcePath","String",apexChunk.GetEditableVariables().First(_ => _.Name == "importFile").ToString());
            values.AddNvValue("authorName","String",Environment.UserName);
            values.AddNvValue("lastModified","String",((CDateTime)apexChunk.GetEditableVariables().First(_ => _.Name == "importFileTimeStamp")).Value.ToString("f"));
            HairWorksInfo.Add(values);
            return HairWorksInfo;
        }
    }
}
