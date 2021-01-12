using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace WolvenKit.Common
{
    [ProtoContract]
    public class ProtoList<T>
    {
        [ProtoMember(1)]
        public List<T> innerlist;
    }
}
