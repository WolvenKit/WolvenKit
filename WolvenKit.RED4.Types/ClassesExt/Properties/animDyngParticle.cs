namespace WolvenKit.RED4.Types
{
    public partial class animDyngParticle
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
