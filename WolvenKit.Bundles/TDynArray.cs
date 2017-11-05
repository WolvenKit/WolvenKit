using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.W3Strings;

namespace WolvenKit.Bundles
{
    class TDynArray<T> : List<T>, ISerializable where T : ISerializable, new()
    {
        public void Deserialize(BinaryReader reader)
        {
            this.Clear();
            Int32 count = reader.ReadBit6().value;
            for (int i = 0; i < count; i++)
            {
                var item = new T();
                item.Deserialize(reader);
                this.Add(item);
            }
        }

        public void Serialize(BinaryWriter writer)
        {
            throw new NotImplementedException();
        }
    }
}
