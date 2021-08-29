using System;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CVector2 : CClass
    {
        [Property(Ordinal = 0)]
        public CFloat X { get; set; } = new();

        [Property(Ordinal = 1)]
        public CFloat Y { get; set; } = new();

        public override string Name => "Vector2";
        public override string ToString() => $"Vector2, X = {X.Value}, Y = {Y.Value}";
        public static CVector2 Parse(string valueString)
        {
            // parse this: 6.7,5
            var splits = valueString.Split(',');
            if (splits.Length != 2)
            {
                throw new FormatException();
            }

            var x = float.Parse(splits[0]);
            var y = float.Parse(splits[1]);

            return new CVector2
            {
                X = x,
                Y = y,
            };
        }
    }
}
