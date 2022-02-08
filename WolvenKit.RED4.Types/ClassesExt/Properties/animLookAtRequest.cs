namespace WolvenKit.RED4.Types
{
    public partial class animLookAtRequest
    {
        [Ordinal(999)]
        [RED("debugInfo")]
        public CString DebugInfo
        {
            get => GetPropertyValue<CString>();
            set => SetPropertyValue<CString>(value);
        }
    }
}
