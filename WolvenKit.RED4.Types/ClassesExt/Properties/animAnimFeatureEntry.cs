namespace WolvenKit.RED4.Types
{
    public partial class animAnimFeatureEntry
    {
        [Ordinal(999)]
        [RED("debugEnabled")]
        public CBool DebugEnabled
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
