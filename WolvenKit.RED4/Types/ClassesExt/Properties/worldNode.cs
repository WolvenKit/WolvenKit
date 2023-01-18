using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
    public partial class worldNode
    {
        [Ordinal(0)]
        [RED("debugName")]
        public CName DebugName
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }

        [Ordinal(1)]
        [RED("sourcePrefabHash")]
        public CUInt64 SourcePrefabHash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }

        [Ordinal(997)]
        [RED("proxyScale")]
        public Vector3 ProxyScale
        {
            get => GetPropertyValue<Vector3>();
            set => SetPropertyValue<Vector3>(value);
        }

        [Ordinal(998)]
        [RED("tag")]
        public CEnum<worldObjectTag> Tag
        {
            get => GetPropertyValue<CEnum<worldObjectTag>>();
            set => SetPropertyValue<CEnum<worldObjectTag>>(value);
        }

        [Ordinal(999)]
        [RED("tagExt")]
        public CEnum<worldObjectTagExt> TagExt
        {
            get => GetPropertyValue<CEnum<worldObjectTagExt>>();
            set => SetPropertyValue<CEnum<worldObjectTagExt>>(value);
        }
    }
}
