namespace WolvenKit.RED4.Types
{
    [REDClass(ChildLevel = 1)]
    public partial class CMesh
    {
        [Ordinal(1)]
        [RED("resourceVersion")]
        public CUInt8 ResourceVersion
        {
            get => GetPropertyValue<CUInt8>();
            set => SetPropertyValue<CUInt8>(value);
        }

        [Ordinal(5)]
        [RED("consoleBias")]
        public CUInt8 ConsoleBias
        {
            get => GetPropertyValue<CUInt8>();
            set => SetPropertyValue<CUInt8>(value);
        }

        [Ordinal(22)]
        [RED("saveDateTime")]
        public CDateTime SaveDateTime
        {
            get => GetPropertyValue<CDateTime>();
            set => SetPropertyValue<CDateTime>(value);
        }

        [Ordinal(997)]
        [RED("geometryHash")]
        public CUInt64 GeometryHash
        {
            get => GetPropertyValue<CUInt64>();
            set => SetPropertyValue<CUInt64>(value);
        }
    }
}
