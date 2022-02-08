namespace WolvenKit.RED4.Types
{
    public partial class RoadBlockControllerPS
    {
        [OrdinalOverride(Before = 105)]
        [RED("hasInteraction")]
        public CBool HasInteraction
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }
    }
}
