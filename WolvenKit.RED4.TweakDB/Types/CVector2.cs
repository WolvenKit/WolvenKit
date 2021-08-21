using System.Diagnostics;
using WolvenKit.RED4.TweakDB.Attributes;

namespace WolvenKit.RED4.TweakDB.Types
{
    [DebuggerDisplay("Vector2, X = {X.Value}, Y = {Y.Value}")]
    public class CVector2 : CClass
    {
        [Property]
        public CFloat X { get; set; } = new();

        [Property]
        public CFloat Y { get; set; } = new();

        public override string Name => "Vector2";
    }
}
