using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class StreamingSectorBuffer : IParseableBuffer
    {
        public IRedType Data => null;

        public Dictionary<int, List<StreamingSectorTransform>> Transforms = new();

        public StreamingSectorBuffer()
        {

        }
    }
}
