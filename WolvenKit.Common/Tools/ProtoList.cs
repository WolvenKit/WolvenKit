using System.Collections.Generic;
using ProtoBuf;

namespace WolvenKit.Common.Tools
{
    [ProtoContract]
    public class ProtoList<T>
    {
        [ProtoMember(1)]
        public List<T> innerlist;
    }
}
