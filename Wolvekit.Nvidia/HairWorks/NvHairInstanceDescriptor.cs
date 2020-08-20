using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace Wolvekit.Nvidia.HairWorks
{
    class NvHairInstanceDescriptor
    {


        public string checksum = "0x4998e6df 0xd4ef511d 0x91f15d9d 0x29c4b445";

        public XElement serialize(CR2WExportWrapper chunk)
        {
            var ret = NvidiaXML.CreateStructHeader("", "Ref", "HairInstanceDescriptor", "1.0", checksum);
            var materialcontainer = new XElement("struct",new XAttribute("name",""));

            var materialcount = new List<CArray>(); //TODO: Get the actual mats
            var structs = new List<XElement>();
            foreach (var mat in materialcount)
            {
                var structelem = new XElement("struct");
                //TODO: Write the actual values!

                structs.Add(structelem);
            }
            materialcontainer.AddNvArray("materials","Struct",structs.Count.ToString(),structs);
            ret.Add(materialcontainer);
            return ret;
        }
    }
}
