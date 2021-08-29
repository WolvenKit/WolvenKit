using System;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    public class CEulerAngles : CClass
    {
        [Property(Ordinal = 0)]
        public CFloat Pitch { get; set; } = new();

        [Property(Ordinal = 1)]
        public CFloat Yaw { get; set; } = new();

        [Property(Ordinal = 2)]
        public CFloat Roll { get; set; } = new();

        public override string Name => "EulerAngles";
        public override string ToString() => $"EulerAngles, Pitch = {Pitch.Value}, Yaw = {Yaw.Value}, Roll = {Roll.Value}";
        public static CEulerAngles Parse(string valueString)
        {
            // parse this: 6.7,5,8.333
            var splits = valueString.Split(',');
            if (splits.Length != 3)
            {
                throw new FormatException();
            }

            var pitch = float.Parse(splits[0]);
            var yaw = float.Parse(splits[1]);
            var roll = float.Parse(splits[2]);

            return new CEulerAngles{
                Pitch = pitch,
                Yaw = yaw,
                Roll = roll
            };
        }
    }
}
