using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
    public class worldNode : worldNode_
    {
        private CName _debugName;
        private CUInt64 _sourcePrefabHash;
        private Vector3 _proxyScale995;
        private CEnum<worldObjectTag> _tag;
        private CEnum<worldObjectTagExt> _tagExt;

        [Ordinal(0)]
        [RED("debugName")]
        public CName DebugName
        {
            get => GetProperty(ref _debugName);
            set => SetProperty(ref _debugName, value);
        }

        [Ordinal(1)]
        [RED("sourcePrefabHash")]
        public CUInt64 SourcePrefabHash
        {
            get => GetProperty(ref _sourcePrefabHash);
            set => SetProperty(ref _sourcePrefabHash, value);
        }

        [Ordinal(997)]
        [RED("proxyScale")]
        public Vector3 ProxyScale_995
        {
            get => GetProperty(ref _proxyScale995);
            set => SetProperty(ref _proxyScale995, value);
        }

        [Ordinal(998)]
        [RED("tag")]
        public CEnum<worldObjectTag> Tag
        {
            get => GetProperty(ref _tag);
            set => SetProperty(ref _tag, value);
        }

        [Ordinal(999)]
        [RED("tagExt")]
        public CEnum<worldObjectTagExt> TagExt
        {
            get => GetProperty(ref _tagExt);
            set => SetProperty(ref _tagExt, value);
        }

        public worldNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
    }
}
