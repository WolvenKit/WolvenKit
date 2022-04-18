using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class WorldTransformsBuffer : IParseableBuffer
    {
        public IRedType Data => Transforms;

        public CArray<worldNodeTransform> Transforms = new();

        public WorldTransformsBuffer()
        {

        }
    }
}
