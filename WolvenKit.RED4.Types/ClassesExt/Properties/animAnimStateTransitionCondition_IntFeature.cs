namespace WolvenKit.RED4.Types
{
    public partial class animAnimStateTransitionCondition_IntFeature
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
