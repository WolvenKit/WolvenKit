namespace WolvenKit.RED4.Types
{
    public partial class animAnimNode_SkAnim
    {
        [Ordinal(28)]
        [RED("debug")]
        public CBool Debug
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        [Ordinal(29)]
        [RED("debugFootsteps")]
        public CBool DebugFootsteps
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
