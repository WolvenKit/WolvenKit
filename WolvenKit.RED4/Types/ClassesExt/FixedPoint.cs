namespace WolvenKit.RED4.Types;

public partial class FixedPoint : IRedPrimitive<float>
{
    // 15.17 bitpacked fixed-point number
    public const float FACTOR = 1.0f / (float)(1 << 17);

    public static implicit operator FixedPoint(CFloat value) => new() { Bits = (int)((float)value / FACTOR) };
    public static implicit operator CFloat(FixedPoint value) => (float)(value.Bits * FACTOR);

    public static implicit operator FixedPoint(float value) => new() { Bits = (int)(value / FACTOR) };
    public static implicit operator float(FixedPoint value) => value.Bits * FACTOR;
}