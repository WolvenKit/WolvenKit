using System.Diagnostics;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("EulerAngles, Pitch = {Pitch.Value}, Yaw = {Yaw.Value}, Roll = {Roll.Value}")]
    public class CEulerAngles : CClass
    {
        [Property]
        public CFloat Pitch { get; set; } = new();

        [Property]
        public CFloat Yaw { get; set; } = new();

        [Property]
        public CFloat Roll { get; set; } = new();

        public override string Name => "EulerAngles";
    }
}
