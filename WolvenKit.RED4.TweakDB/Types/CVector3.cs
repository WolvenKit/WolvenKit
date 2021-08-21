using System.Diagnostics;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Vector3, X = {X.Value}, Y = {Y.Value}, Z = {Z.Value}")]
    public class CVector3 : CClass
    {
        [Property]
        public CFloat X { get; set; } = new();

        [Property]
        public CFloat Y { get; set; } = new();

        [Property]
        public CFloat Z { get; set; } = new();

        public override string Name => "Vector3";
    }
}
