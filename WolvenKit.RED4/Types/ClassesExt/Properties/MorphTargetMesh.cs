namespace WolvenKit.RED4.Types
{
    public partial class MorphTargetMesh
    {
        [Ordinal(999)]
        [RED("resourceVersion")]
        public CUInt8 ResourceVersion
        {
            get => GetPropertyValue<CUInt8>();
            set => SetPropertyValue<CUInt8>(value);
        }
    }
}
