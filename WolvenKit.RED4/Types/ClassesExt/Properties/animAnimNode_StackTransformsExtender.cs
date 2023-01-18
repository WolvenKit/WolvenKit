namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_StackTransformsExtender
    {
        [Ordinal(998)]
        [RED("shrinkerNodeId")]
        public CUInt32 ShrinkerNodeId
        {
            get => GetPropertyValue<CUInt32>();
            set => SetPropertyValue<CUInt32>(value);
        }
    }
}
