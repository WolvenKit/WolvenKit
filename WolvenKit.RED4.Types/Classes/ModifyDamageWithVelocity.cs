using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ModifyDamageWithVelocity : ModifyDamageEffector
	{
		[Ordinal(2)] 
		[RED("percentMult")] 
		public CFloat PercentMult
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("unitThreshold")] 
		public CFloat UnitThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
