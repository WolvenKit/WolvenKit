namespace WolvenKit.RED4.Types
{
    // TODO: Check Ordinal
    public partial class animDyngConstraintCone
    {
        [Ordinal(0)]
        [RED("isDebugEnabled")]
        public CBool IsDebugEnabled
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        partial void PostConstruct()
        {
            IsDebugEnabled = true;
        }
    }
}
