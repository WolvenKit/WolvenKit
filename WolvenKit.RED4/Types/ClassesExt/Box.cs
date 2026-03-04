namespace WolvenKit.RED4.Types;

public partial class Box
{
    public Box(Box other)
    {
        Min = new Vector4(other.Min);
        Max = new Vector4(other.Max);
    }
}
