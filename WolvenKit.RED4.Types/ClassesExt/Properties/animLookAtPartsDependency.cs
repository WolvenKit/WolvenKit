namespace WolvenKit.RED4.Types
{
    public partial class animLookAtPartsDependency : IRedOverload
    {
        [Ordinal(998)]
        [RED("innerSquareColor")]
        public CColor InnerSquareColor
        {
            get => GetPropertyValue<CColor>();
            set => SetPropertyValue<CColor>(value);
        }

        [Ordinal(999)]
        [RED("outerSquareColor")]
        public CColor OuterSquareColor
        {
            get => GetPropertyValue<CColor>();
            set => SetPropertyValue<CColor>(value);
        }

        void IRedOverload.ConstructorOverload()
        {
            InnerSquareColor = new();
            OuterSquareColor = new();
        }
    }
}
