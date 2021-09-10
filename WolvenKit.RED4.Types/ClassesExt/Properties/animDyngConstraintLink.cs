namespace WolvenKit.RED4.Types
{
    // TODO: Check Ordinal
    public partial class animDyngConstraintLink : IRedOverload
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
