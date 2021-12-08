using System;
using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FixedPoint : RedBaseClass, IRedPrimitive<float>
    {
		[Ordinal(0)] 
		[RED("Bits")] 
		public CInt32 Bits
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
        }

        public const float FACTOR = 0.0000076293945F;

        public static implicit operator FixedPoint(CFloat value) => new() { Bits = (int)((float)value / FACTOR) };
        public static implicit operator CFloat(FixedPoint value) => (float)(value.Bits * FACTOR);

        public static implicit operator FixedPoint(float value) => new() { Bits = (int)(value / FACTOR) };
        public static implicit operator float(FixedPoint value) => value.Bits * FACTOR;
    }
}
