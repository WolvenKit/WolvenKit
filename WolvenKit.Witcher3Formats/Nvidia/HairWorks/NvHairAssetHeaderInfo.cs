using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.Nvidia.HairWorks
{
    internal class NvHairAssetHeaderInfo
    {
#pragma warning disable CS0414  // ~~~[[maybe_unused]] c++ compiler attribute
        private string fileVersion = "1.0";
        private string authorName = "WolvenKit";
#pragma warning restore CS0414

        //private string toolVersion = "WolvenKit " +
        //                FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

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
        public XElement serialize(CFurMeshResource apexChunk, int objectcount)
        {
            var HairWorksInfo = NvidiaXML.CreateStructHeader("", "Ref", "HairWorksInfo", "1.0", checksum);
            var values = new XElement("struct", new XAttribute("name", ""));
            values.AddNvValue("fileVersion", "String", "1.0");
            values.AddNvValue("toolVersion", "String", "WolvenKit");
            values.AddNvValue("sourcePath", "String", apexChunk.GetEditableVariables().First(_ => _.REDName == "importFile").ToString());
            values.AddNvValue("authorName", "String", Environment.UserName);
            values.AddNvValue("lastModified", "String", ((CDateTime)apexChunk.GetEditableVariables().First(_ => _.REDName == "importFileTimeStamp")).DValue.ToString("f"));
            HairWorksInfo.Add(values);
            return HairWorksInfo;
        }
    }
}
