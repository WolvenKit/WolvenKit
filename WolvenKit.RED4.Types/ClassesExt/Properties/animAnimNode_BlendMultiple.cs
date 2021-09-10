namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_BlendMultiple
    {
        [Ordinal(999)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
