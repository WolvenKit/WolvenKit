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
        
    }
}
