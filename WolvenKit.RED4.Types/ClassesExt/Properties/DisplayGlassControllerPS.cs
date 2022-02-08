namespace WolvenKit.RED4.Types
{
    public partial class DisplayGlassControllerPS
    {
        [OrdinalOverride(Before = 15)]
        [RED("tvSetup")]
        public TVSetup TvSetup
        {
            get => GetPropertyValue<TVSetup>();
            set => SetPropertyValue<TVSetup>(value);
        }
    }
}
