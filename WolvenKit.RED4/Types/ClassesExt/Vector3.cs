namespace WolvenKit.RED4.Types;

public partial class Vector3
{
    public static implicit operator Vector3(System.Numerics.Vector3 v) =>
        new Vector3 { X = v.X, Y = v.Y, Z = v.Z };

    public static implicit operator System.Numerics.Vector3(Vector3 v) =>
        new System.Numerics.Vector3 { X = v.X, Y = v.Y, Z = v.Z };

    public Vector3(Vector3 other)
    {
        X = other.X;
        Y = other.Y;
        Z = other.Z;
    }

    public override string ToString() => $"Vector3, X = {X}, Y = {Y}, Z = {Z}";
}
