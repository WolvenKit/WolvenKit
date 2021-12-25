namespace WolvenKit.RED4.Types
{
    public partial class TVSetup
    {
        [OrdinalOverride(Before = 1)]
        [RED("useWhiteNoiseFX")]
        public CBool UseWhiteNoiseFX
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
