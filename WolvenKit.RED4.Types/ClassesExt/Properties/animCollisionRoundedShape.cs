namespace WolvenKit.RED4.Types
{
    public partial class animCollisionRoundedShape
    {
        [Ordinal(999)]
        [RED("drawAxis")]
        public CBool DrawAxis
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        partial void PostConstruct()
        {
            DrawAxis = true;
        }
    }
}
