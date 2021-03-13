using System.Collections.Generic;
using System.Xml.Linq;
using WolvenKit.RED3.CR2W.Types;

namespace WolvenKit.Nvidia.HairWorks
{
    internal class NvHairInstanceDescriptor
    {
        #region Fields

        public string checksum = "0x4998e6df 0xd4ef511d 0x91f15d9d 0x29c4b445";

        #endregion Fields

        #region Methods

        public XElement serialize(CFurMeshResource chunk)
        {
            var ret = NvidiaXML.CreateStructHeader("", "Ref", "HairInstanceDescriptor", "1.0", checksum);
            var materialcontainer = new XElement("struct", new XAttribute("name", ""));

            var materialcount = chunk.Materials;
            var structs = new List<XElement>();
            foreach (var mat in materialcount)
            {
                var structelem = new XElement("struct");
                //TODO: Write the actual values!

                structs.Add(structelem);
            }
            materialcontainer.AddNvArray("materials", "Struct", structs.Count.ToString(), structs);
            ret.Add(materialcontainer);
            return ret;
        }

        #endregion Methods
    }
}
