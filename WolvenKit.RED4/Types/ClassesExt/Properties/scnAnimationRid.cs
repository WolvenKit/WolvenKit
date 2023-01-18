namespace WolvenKit.RED4.Types
{
    public partial class scnAnimationRid
    {
        [Ordinal(999)]
        [RED("backendData")]
        public CHandle<IBackendData> BackendData
        {
            get => GetPropertyValue<CHandle<IBackendData>>();
            set => SetPropertyValue<CHandle<IBackendData>>(value);
        }
    }
}
