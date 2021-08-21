using System.Diagnostics;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Color, Red = {Red.Value}, Green = {Green.Value}, Blue = {Blue.Value}, Blue = {Alpha.Value}")]
    public class CColor : CClass
    {
        [Property(Ordinal = 0)]
        public CUint8 Red { get; set; } = new();

        [Property(Ordinal = 1)]
        public CUint8 Green { get; set; } = new();

        [Property(Ordinal = 2)]
        public CUint8 Blue { get; set; } = new();

        [Property(Ordinal = 3)]
        public CUint8 Alpha { get; set; } = new();

        public override string Name => "Color";
    }
}
