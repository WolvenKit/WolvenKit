using System;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CVector3 : CClass
    {
        [Property(Ordinal = 0)]
        public CFloat X { get; set; } = new();

        [Property(Ordinal = 1)]
        public CFloat Y { get; set; } = new();

        [Property(Ordinal = 2)]
        public CFloat Z { get; set; } = new();

        public override string Name => "Vector3";
        public override string ToString() => $"Vector3, X = {X.Value}, Y = {Y.Value}, Z = {Z.Value}";
        public static CVector3 Parse(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 3)
            {
                throw new FormatException();
            }

            var x = float.Parse(splits[0]);
            var y = float.Parse(splits[1]);
            var z = float.Parse(splits[2]);

            return new CVector3
            {
                X = x,
                Y = y,
                Z = z
            };
        }
    }
}
