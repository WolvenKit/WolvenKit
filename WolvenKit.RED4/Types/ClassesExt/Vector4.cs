namespace WolvenKit.RED4.Types
{
    public partial class Vector4
    {
        public static implicit operator Vector4(System.Numerics.Vector4 v) =>
            new Vector4 { X = v.X, Y = v.Y, Z = v.Z, W = v.W };

        public static implicit operator System.Numerics.Vector4(Vector4 v) =>
            new System.Numerics.Vector4 { X = v.X, Y = v.Y, Z = v.Z, W = v.W };

        public override string ToString() => $"Vector4, X = {X}, Y = {Y}, Z = {Z}, W = {W}";
    }
}
