using System;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CQuaternion : CClass
    {
        [Property(Name = "i", Ordinal = 0)]
        public CFloat I { get; set; } = new();

        [Property(Name = "j", Ordinal = 1)]
        public CFloat J { get; set; } = new();

        [Property(Name = "k", Ordinal = 2)]
        public CFloat K { get; set; } = new();

        [Property(Name = "r", Ordinal = 3)]
        public CFloat R { get; set; } = new();

        public override string Name => "Quaternion";
        public override string ToString() => $"Quaternion, i = {I.Value}, j = {J.Value}, k = {K.Value}, r = {R.Value}";
        public static CQuaternion Parse(string valueString)
        {
            // parse this: 6.7,5,8.333,0
            var splits = valueString.Split(',');
            if (splits.Length != 4)
            {
                throw new FormatException();
            }

            var i = float.Parse(splits[0]);
            var j = float.Parse(splits[1]);
            var k = float.Parse(splits[2]);
            var r = float.Parse(splits[2]);

            return new CQuaternion
            {
                I = i,
                J = j,
                K = k,
                R = r
            };
        }
    }
}
