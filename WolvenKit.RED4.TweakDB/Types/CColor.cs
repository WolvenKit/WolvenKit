using System;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
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
        public override string ToString() => $"Color, Red = {Red.Value}, Green = {Green.Value}, Blue = {Blue.Value}, Blue = {Alpha.Value}";
        public static CColor Parse(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 4)
            {
                throw new FormatException();
            }

            var red = byte.Parse(splits[0]);
            var green = byte.Parse(splits[1]);
            var blue = byte.Parse(splits[2]);
            var alpha = byte.Parse(splits[2]);

            return new CColor
            {
                Red = red,
                Green = green,
                Blue = blue,
                Alpha = alpha
            };
        }
    }
}
