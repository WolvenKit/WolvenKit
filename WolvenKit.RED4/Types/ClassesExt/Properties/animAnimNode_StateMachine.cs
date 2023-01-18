namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_StateMachine
    {
        [Ordinal(999)]
        [RED("debugFlag")]
        public CBool DebugFlag
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [Ordinal(1000)]
        [RED("debugName")]
        public new CName DebugName
        {
            get => GetPropertyValue<CName>();
            set => SetPropertyValue<CName>(value);
        }
    }
}
