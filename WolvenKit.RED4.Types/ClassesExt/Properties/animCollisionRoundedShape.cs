namespace WolvenKit.RED4.Types
{
    public partial class animCollisionRoundedShape : IRedOverload
    {
        [Ordinal(999)]
        [RED("drawAxis")]
        public CBool DrawAxis
        {
            get => GetPropertyValue<CBool>();
            set => SetPropertyValue<CBool>(value);
        }

        void IRedOverload.ConstructorOverload()
        {
            DrawAxis = true;
        }
    }
}
