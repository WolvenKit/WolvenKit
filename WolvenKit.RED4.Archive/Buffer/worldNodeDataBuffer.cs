using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.Buffer
{
    public class worldNodeDataBuffer : CArray<worldNodeData>, IParseableBuffer, IRedType
    {
        public IRedType Data => null;

        public Dictionary<int, List<worldNodeData>> Lookup = new();

        public worldNodeDataBuffer()
        {

        }
    }

    public class RedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IRedType
    {

    }
}
