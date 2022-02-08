namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_FloatInput
    {
        [Ordinal(999)]
        [RED("debugInput")]
        public CBool DebugInput
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
