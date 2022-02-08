namespace WolvenKit.RED4.Types
{
    public partial class animLipsyncMapping
    {
        [Ordinal(3)]
        [RED("scenePreviewPaths")]
        public CArray<CUInt64> ScenePreviewPaths
        {
            get => GetPropertyValue<CArray<CUInt64>>();
            set => SetPropertyValue<CArray<CUInt64>>(value);
        }
    }
}
