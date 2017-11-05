using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.Bundles
{
    interface ISerializable
    {
        void Deserialize(BinaryReader reader);
        void Serialize(BinaryWriter writer);
    }
}
