using System.Diagnostics;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Quaternion, i = {I.Value}, j = {J.Value}, k = {K.Value}, r = {R.Value}")]
    public class CQuaternion : CClass
    {
        [Property(Name = "i")]
        public CFloat I { get; set; } = new();

        [Property(Name = "j")]
        public CFloat J { get; set; } = new();

        [Property(Name = "k")]
        public CFloat K { get; set; } = new();

        [Property(Name = "r")]
        public CFloat R { get; set; } = new();

        public override string Name => "Quaternion";
    }
}
