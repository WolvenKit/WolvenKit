namespace WolvenKit.RED4.Types
{
    public partial class Vector2
    {
        public static implicit operator Vector2(System.Numerics.Vector2 v) =>
       new Vector2 { X = v.X, Y = v.Y};

        public static implicit operator System.Numerics.Vector2(Vector2 v) =>
            new System.Numerics.Vector2 { X = v.X, Y = v.Y};

        public override string ToString() => $"Vector2, X = {X}, Y = {Y}";
    }
}
