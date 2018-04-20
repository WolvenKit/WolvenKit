using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WolvenKit.CR2W;

namespace Wolvekit.Nvidia.HairWorks
{
    class NvHairAssetDescriptor
    {

        public string checksum = "0x299b335f 0x2cad8b54 0xcaf3c98f 0xa3094fa7";

        public XElement serialize(CR2WChunk chunk)
        {
            var ret = NvidiaXML.CreateStructHeader("", "Ref", "HairSceneDescriptor", "1.0", checksum);
            //TODO: Array formating bs.
            return ret;
        }
    }
}
