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
        public IRedType Data => AllTransforms;

        public CArray<StreamingSectorTransform> AllTransforms = new();

        public Dictionary<int, List<StreamingSectorTransform>> Transforms = new();

        public StreamingSectorBuffer()
        {

        }
    }

    public class RedDictionary<TKey, TValue> : Dictionary<TKey, TValue>, IRedType
    {

    }
}
