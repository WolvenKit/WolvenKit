namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_StackTracksExtender
    {
        [Ordinal(999)]
        [RED("shrinkerNodeId")]
        public CUInt32 ShrinkerNodeId
        {
            get => GetPropertyValue<CUInt32>();
            set => SetPropertyValue<CUInt32>(value);
        }
    }
}
