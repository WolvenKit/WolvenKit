namespace WolvenKit.RED4.Types
{
    // TODO: Check Ordinal
    public partial class animAnimVariableBool
    {
        [Ordinal(1)]
        [RED("enableDebug")]
        public CBool EnableDebug
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
