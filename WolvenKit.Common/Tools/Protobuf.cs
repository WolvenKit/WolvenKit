using System.Collections.Generic;
using ProtoBuf;

namespace WolvenKit.Common
{
    [ProtoContract]
    public class ProtoList<T>
    {
        #region Fields

        [ProtoMember(1)]
        public List<T> innerlist;

        #endregion Fields
    }


}
