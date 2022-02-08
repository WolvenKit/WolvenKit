namespace WolvenKit.RED4.Types
{
    public partial class animDyngParticle : IRedOverload
    {
        [Ordinal(0)]
        [RED("isDebugEnabled")]
        public CBool IsDebugEnabled
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        void IRedOverload.ConstructorOverload()
        {
            IsDebugEnabled = true;
        }
    }
}
