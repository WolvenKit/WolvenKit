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
        
    }
}
