namespace WolvenKit.RED4.Types
{
    [RED("Color")]
    public partial class CColor
    {
        public override string ToString() => $"Color, Red = {Red}, Green = {Green}, Blue = {Blue}, Blue = {Alpha}";
    }
}
