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
        
    }
}
